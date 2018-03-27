using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data.Common;
using System.Data.SQLite;
using MaterialSkin;
using MaterialSkin.Controls;
namespace MaterialSkinExample
{
    public partial class Form_Browser : MaterialForm
    {
        ToolStripMenuItem Add_PlayList_Item = new ToolStripMenuItem("Добавить в плейлист");
        ToolStripMenuItem Cancel_Item = new ToolStripMenuItem("Отмена");


        public Form_Browser()
        {
            InitializeComponent();
            List_genre.Add("biografiyi");
            List_genre.Add("boeviki");
            List_genre.Add("vesterny");
            List_genre.Add("voennye");
            List_genre.Add("detektivy");
            List_genre.Add("detskie");
            List_genre.Add("dokumentalnye");
            List_genre.Add("dramy");
            List_genre.Add("istoricheskie");
            List_genre.Add("komedii");
            List_genre.Add("kriminal");
            List_genre.Add("melodramy");
            List_genre.Add("multfilmy");
            List_genre.Add("mjuzikly");
            List_genre.Add("otechestvenie");
            List_genre.Add("prikljuchenija");
            List_genre.Add("semejnye");
            List_genre.Add("sportivnye");
            List_genre.Add("trillery");
            List_genre.Add("uzhasy");
            List_genre.Add("fantastika");
            List_genre.Add("fjentjezi");
            // menu.Items.Add("Добавить в плейлист");
            // menu.Items.Add("Отмена");
            timer1.Tick += Timer1_Tick;
            comboBox_Genre.SelectedIndex = 0;
            comboBox_Genre.SelectedIndexChanged += FilmBox_SelectedIndexChanged;
            // menu.MouseClick += Menu_MouseClick;
            Add_PlayList_Item.Click += Add_PlayList_Item_Click;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            select_genre();
            add_PicrureBox();
            comboBox1.SelectedIndex = 0;
        }

        private void FilmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            NumberStr = 1;
            select_genre();
            comboBox1.SelectedIndex = 0;

            Draw();
        }

        private void Draw()
        {
            Task[] MyTask = new Task[2];
            MyTask[0] = new Task(Draw_Thread0);
            MyTask[1] = new Task(Draw_Thread1);
            MyTask[0].Start();
            MyTask[1].Start();
        }
        int NumberStr = 2;
        string http = "http://kinogo.club/";
        int str_all = 0;
        private void select_genre()
        {
            count_str_all(getResponse(http + List_genre[comboBox_Genre.SelectedIndex] + "/page/" + 1 + "/"));
            for (int i = 1; i <= str_all; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            //Thread.Sleep(1000);
            // FilmBox.Controls.Clear();
            load();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumberStr = (int)comboBox1.SelectedItem;
            load();
            Draw();
        }

        int i = 0;
        private void load()
        {
            Temp_List.Clear();
            Array.Clear(red_text, 0, 0);
            NameFilm.Clear();
            LinkFilm.Clear();
            LinkPoster.Clear();
            Parse_Block_Film(http + List_genre[comboBox_Genre.SelectedIndex] + "/page/" + NumberStr + "/");
            Parse_Link_Film(Temp_List);
            Parse_Red_Text(Temp_List);
            Parse_Name_Film(Temp_List);
            Parse_Poster_Film(Temp_List);
        }



        string path = "http://kinogo.club";
        List<string> List_genre = new List<string>();
        List<PictureBox> ListPB = new List<PictureBox>();
        List<LinkLabel> ListLL = new List<LinkLabel>();
        List<string> Temp_List = new List<string>();
        List<string> NameFilm = new List<string>();
        List<string> LinkFilm = new List<string>();
        List<string> LinkPoster = new List<string>();
        string[] red_text = new string[10];
        //Получаем количество серий на странице
        private void count_str(string url, out int count)
        {
            url = getResponse(url);

            //Определяем количество серий
            int i = 0;
            int x = -1;
            count = -1;

            while (i != -1)
            {
                i = url.IndexOf("Продолжительность", x + 1); // получаем индекс первого вхождения  х+1 говорит, что начинать нужно с 0-го индекса, тоесть с буквы "П"
                x = i; // соответственно присваиваем номер индекса первого значения, что б потом (х+1) начать со следующего
                count++;  // Увеличиваем на единицу наше количество
            }

        }
        //Получаем количество страниц всего
        private void count_str_all(string page)
        {
            string result = page.Substring(page.IndexOf("Раньше", 0));

            string[] trimmed = result.Split(new[] { "http://kinogo.club/" + List_genre[comboBox_Genre.SelectedIndex] + "/page/" }, StringSplitOptions.None);
            //LinkPoster.Add(trimmed[0]);
            // str_all = int.Parse(trimmed[0]);
            result = trimmed[10].Substring(trimmed[10].IndexOf("\">", 0));
            trimmed = result.Split(new[] { "</a>" }, StringSplitOptions.None);
            trimmed[0] = trimmed[0].Replace("\">", "");
            str_all = int.Parse(trimmed[0]);
            // MessageBox.Show(str_all.ToString());
        }
        //Получаем отдельные страницы для разбора
        private void Parse_Block_Film(string url)
        {
            string result = getResponse(url);
            string two = result;
            int count = 0;
            count_str(url, out count);
            for (int i = 0; i < count; i++)
            {
                result = two.Substring(two.IndexOf("zagolovki", 0));
                string[] trimmed = result.Split(new[] { "<!--shortstory-->" }, StringSplitOptions.None);
                Temp_List.Add(trimmed[0]);
                two = two.Replace(trimmed[0], "");
            }


            //     Calculate_Picture(FilmBoxf, LinkPoster);
        }
        //Получаем ссылку на фильм
        private void Parse_Link_Film(List<string> List_Page)
        {
            for (int i = 0; i < List_Page.Count; i++)
            {
                string result = List_Page[i].Substring(List_Page[i].IndexOf("http://kinogo.club/", 0));
                string[] trimmed = result.Split(new[] { "\">" }, StringSplitOptions.None);
                LinkFilm.Add(trimmed[0]);
                Temp_List[i] = Temp_List[i].Replace(trimmed[0], "");
            }
        }
        //Получаем название фильма
        private void Parse_Name_Film(List<string> List_Page)
        {
            for (int i = 0; i < List_Page.Count; i++)
            {
                string result = List_Page[i].Substring(List_Page[i].IndexOf("title='", 0));
                string[] trimmed = result.Split('\'');
                //  trimmed[0]=trimmed[0].Replace("\"\">", "");
                NameFilm.Add(trimmed[1]);
                Temp_List[i] = Temp_List[i].Replace(trimmed[1], "");
            }
        }
        //Получаем в случае наличия слова "лицензия", "Серия" и т.п.
        private void Parse_Red_Text(List<string> List_Page)
        {
            for (int i = 0; i < List_Page.Count; i++)
            {
                if (Temp_List[i].Contains("class=\"cont\">") == true)
                {
                    string result = Temp_List[i].Substring(Temp_List[i].IndexOf("class=\"cont\">", 0));
                    string[] trimmed = result.Split(new[] { "</div></div><div" }, StringSplitOptions.None);
                    result = trimmed[0].Replace("class=\"cont\">", "");
                    //  LinkPoster.Add(trimmed[1]);
                    //  MessageBox.Show(""+result);
                    red_text[i] = result;
                    //   Temp_List[i] = Temp_List[i].Replace(trimmed[1], "");
                }
            }
        }
        //Получаем постер фильма
        private void Parse_Poster_Film(List<string> List_Page)
        {
            for (int i = 0; i < List_Page.Count; i++)
            {
                string result = List_Page[i].Substring(List_Page[i].IndexOf("<img src=\"", 0));
                string[] trimmed = result.Split('"');
                LinkPoster.Add(trimmed[1]);
                Temp_List[i] = Temp_List[i].Replace(trimmed[1], "");
            }
        }
        private static string getResponse(string uri)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }
        PictureBox[] PB = new PictureBox[10];
        LinkLabel[] LL = new LinkLabel[10];
        Label[] LBL = new Label[10];
        private void add_PicrureBox()
        {
            int x = 10;
            int y = 0;
            int temp_location = 0;
            int count = 0;
            int between = 0;
            for (int i = 0; i < PB.Length; i++)
            {
                PB[i] = new PictureBox();
                // LBL[i] = new Label();
                if (count >= SystemInformation.PrimaryMonitorSize.Width / 200) { temp_location = 0; y += 300; count = 0; between = 0; y += 10; }
                PB[i].Location = new Point(temp_location + between, y);
                PB[i].Size = new Size(200, 300);
                // PB[i].Load(path + LinkPoster[i]);
                PB[i].SizeMode = PictureBoxSizeMode.StretchImage;
                PB[i].Load(http + LinkPoster[i]);
                //LinkLabel
                LL[i] = new LinkLabel();
                LL[i].Location = new Point(temp_location + between, y);
                LL[i].Font = new Font("Arial", 12, FontStyle.Bold);
                LL[i].BackColor = Color.FromArgb(29, 29, 29);
                LL[i].LinkColor = Color.White;
                LL[i].MaximumSize = new Size(200, 80);
                LL[i].AutoSize = true;
                LL[i].LinkBehavior = LinkBehavior.NeverUnderline;
                LL[i].Text = NameFilm[i];
                LL[i].Name = LinkFilm[i];
                LL[i].MouseClick += Form1_MouseClick;

                //Redtext
                //if (red_text[i] != null)
                //{

                //    LBL[i].Text = red_text[i];
                //    LBL[i].BringToFront();
                //    LBL[i].ForeColor = Color.White;
                //    LBL[i].Font = new Font("Arial", 10, FontStyle.Bold);
                //    LBL[i].Location = new Point(temp_location + between + 100, y + 260);
                //    LBL[i].MaximumSize = new Size(200, 20);
                //    LBL[i].BackColor = Color.FromArgb(138, 33, 46);
                //    //Panel.Controls.Add(LA);
                //  //  GroupBox.Controls.Add(LBL[i]);
                //}

                //AddGroupBox
                panel1.Controls.Add(LL[i]);
                panel1.Controls.Add(PB[i]);


                //   GroupBox.Invoke(new Action(() => { GroupBox.Controls.Add(LL[i]); }));
                //  GroupBox.Invoke(new Action(() => { GroupBox.Controls.Add(PB[i]); }));

                //Пересчет
                count++; temp_location += 200; between += 10;
            }
        }
        ContextMenuStrip ooo = new ContextMenuStrip();
        string Link_Url = "";
        string Video_Name = "";
        string Link_Poser = "";
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            LinkLabel obj = (LinkLabel)sender;
            if (e.Button == MouseButtons.Left)
            {

                string[] args = { obj.Name };
                MainForm player = new MainForm(args);
                player.ShowDialog();
                //   MessageBox.Show(obj.Name);

            }
            if (e.Button == MouseButtons.Right)
            {
                Link_Url = obj.Name;
                Video_Name = obj.Text;


                ooo.Items.AddRange(new[] { Add_PlayList_Item, Cancel_Item });
                ooo.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }
        private void Add_PlayList_Item_Click(object sender, EventArgs e)
        {

            Class_Function.add_playlist(Link_Url, Video_Name);
            //  MessageBox.Show("Добавлено\n"+ Link_Url+" "+Video_Name);
        }
        private void Draw_Thread0()
        {
            try
            {
                for (int i = 0; i < PB.Length - 5; i++)
                {
                    LL[i].Invoke(new Action(() => { LL[i].Text = NameFilm[i]; }));
                    LL[i].Invoke(new Action(() => { LL[i].Name = LinkFilm[i]; }));
                    PB[i].Load("http://kinogo.club" + LinkPoster[i]);
                    // LBL[i].Text = red_text[i];
                    //LL[i].Text = NameFilm[i];
                    //   LL[i].Text = NameFilm[i];
                    //  LL[i].Name = LinkFilm[i]; 

                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Запрос был неожиданно прерван.");
            }
        }
        private void Draw_Thread1()
        {
            try
            {
                for (int i = 5; i < PB.Length; i++)
                {
                    LL[i].Invoke(new Action(() => { LL[i].Text = NameFilm[i]; }));
                    LL[i].Invoke(new Action(() => { LL[i].Name = LinkFilm[i]; }));
                    PB[i].Load("http://kinogo.club" + LinkPoster[i]);
                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Запрос был неожиданно прерван.");
            }
        }

        public void Calculate_Picture(GroupBox Panel, List<string> Poster)
        {
            int x = 10;
            int y = 0;
            int temp_location = 0;
            int count = 0;
            int between = 0;
            for (int i = 0; i < Poster.Count; i++)
            {
                var PB = new PictureBox();
                var LL = new LinkLabel();
                var LA = new Label();
                PB.Size = new Size(200, 300);
                if (count == 5) { temp_location = 0; y += 300; count = 0; between = 0; y += 10; }
                PB.Location = new Point(temp_location + between, y);
                PB.Load(path + Poster[i]);
                PB.SizeMode = PictureBoxSizeMode.StretchImage;
                //  ListPB.Add(PB);
                LL.Location = new Point(temp_location + between, y);
                LL.Text = NameFilm[i];
                LL.Font = new Font("Arial", 12, FontStyle.Bold);
                LL.BackColor = Color.FromArgb(29, 29, 29);
                LL.LinkColor = Color.White;
                LL.MaximumSize = new Size(200, 80);
                LL.AutoSize = true;
                LL.LinkBehavior = LinkBehavior.NeverUnderline;
                LL.Name = LinkFilm[i];
                //   LL.MouseClick += LL_MouseClick;
                //  ListLL.Add(LL);
                if (red_text[i] != null)
                {
                    LA.Text = red_text[i];
                    LA.BringToFront();
                    LA.ForeColor = Color.White;
                    LA.Font = new Font("Arial", 10, FontStyle.Bold);
                    LA.Location = new Point(temp_location + between + 100, y + 260);
                    LA.MaximumSize = new Size(200, 20);
                    LA.BackColor = Color.FromArgb(138, 33, 46);
                    Panel.Controls.Add(LA);
                }
                Panel.Controls.Add(LL);
                Panel.Controls.Add(PB);
                count++; temp_location += 200; between += 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberStr++;
            load();
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  Form_my_Playlist pl = new Form_my_Playlist();
            //   pl.Show();
            //  Draw();
        }
    }
   
}
