using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;
using System.Data.Common;
using System.IO;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using MetroFramework;
using My_Download;
using System.Net;

namespace MaterialSkinExample
{
    public partial class Form_PlayList : MaterialForm
    {
        string[] args;
        private readonly MaterialSkinManager materialSkinManager;
        List<string> cache_url;
        
        static string cache_name = "";
       static string cache_path = "MadMaxNiceDownload\\"+cache_name;
        string old_http = "";
        ToolStripMenuItem Download_Item= new ToolStripMenuItem("Скачать для просмотра в оффлайн");
        ToolStripMenuItem Cancel_Item = new ToolStripMenuItem("Отмена");
        ContextMenuStrip menu_right_button = new ContextMenuStrip();
        public Form_PlayList(string[] args)
        {
            InitializeComponent();
            Download_Item.Click += Download_Item_Click;
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red900, Primary.Indigo100, Accent.Pink200, TextShade.BLACK);
            SQL_Open_video();
            create_box();
        }

        private void Download_Item_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            Directory.CreateDirectory(cache_path + "\\" + cache_name + "\\");
            int y = 0;
            groupBox1.Size = new Size(616, 25 * cache_url.Count + 35);
            for (int i = 0; i < cache_url.Count; i++)
            {
                if (cache_url.Count > 1)
                {
                    if (File.Exists(cache_path + "\\" + cache_name + "\\" + (i + 1) + ". " + cache_name + ".mp4") == false)
                    {
                        WebClient download = new WebClient();
                        var PRB = new MetroProgressBar();
                        PRB.Location = new Point(0, y + 35);
                        PRB.Size = new Size(616, 25);
                        groupBox1.Controls.Add(PRB);
                        download.DownloadProgressChanged += (o, args) => PRB.Value = args.ProgressPercentage;
                        download.DownloadFileCompleted += (o, args) => PRB.Value = 0;
                       download.DownloadFileAsync(new Uri(cache_url[i]), cache_path + "\\" + cache_name + "\\" + (i + 1) + ". " + cache_name + ".mp4");
                        y += 25;

                    }
                    Class_Function.SQL_Update_link_download(old_http, cache_path + "\\" + cache_name);
                }
                else
                if (File.Exists(cache_path + "\\" + cache_name + "\\" + cache_name + ".mp4") == false)
                {
                    WebClient download = new WebClient();
                    var PRB = new MetroProgressBar();
                    PRB.Location = new Point(0, y + 35);
                    PRB.Size = new Size(616, 25);
                    groupBox1.Controls.Add(PRB);
                    download.DownloadProgressChanged += (o, args) => PRB.Value = args.ProgressPercentage;
                    download.DownloadFileAsync(new Uri(cache_url[i]), cache_path + "\\" + cache_name + "\\" + cache_name + ".mp4");
                    y += 25;
                }

                Class_Function.SQL_Update_link_download(old_http, cache_path + "\\" + cache_name);
            }

          
            //Замена ссылки в БД


            //   download.DownloadFile("http://vscode.ru/filesForArticles/test.docx", cache_path+"\\"+cache_name+"\\" + cache_name+".mp4");

            //Video.video_download(download_url, download_path, download_name);
        }
        private void TaskDownload()
        {       
        }
        List<string> List_Poster = new List<string>();
        List<string> List_Name = new List<string>();
        List<string> List_file = new List<string>();
        List<string> List_url = new List<string>();
        //  PictureBox[] PB = new PictureBox[5];

        private void create_box()
        {
           
            int temp_location = 0;
            int between = 0;
            int y = 0;
            int count = 0;
            for (int i = 0; i < List_Poster.Count; i++)
            {
                var PB = new PictureBox();
                var LL = new LinkLabel();
                //  PB[i] = new PictureBox();
                if (count >= SystemInformation.PrimaryMonitorSize.Width/200) { temp_location = 0; y += 310; count = 0; between = 0; }
                PB.Location = new Point(temp_location + between, y);
                PB.Size = new Size(200, 300);
                PB.Load(List_Poster[i]);
                PB.SizeMode = PictureBoxSizeMode.StretchImage;
           
                LL.Location = new Point(temp_location + between, y);
                LL.Font = new Font("Arial", 12, FontStyle.Bold);
                LL.BackColor = Color.FromArgb(29, 29, 29);
                LL.LinkColor = Color.White;
                LL.MaximumSize = new Size(200, 80);
                LL.AutoSize = true;
                LL.LinkBehavior = LinkBehavior.NeverUnderline;
                LL.Text = List_Name[i];
                LL.Name = List_file[i];
                LL.MouseClick += LL_MouseClick;
                panel1.Controls.Add(LL);
                panel1.Controls.Add(PB);
               // groupBox1.Controls.Add(LL);
               // groupBox1.Controls.Add(PB);

                //
                temp_location += 200;
                between += 10;
                count++;
            }
        }
       
        private void LL_MouseClick(object sender, MouseEventArgs e)
        {
            LinkLabel lbl = (LinkLabel)sender;
            if (e.Button == MouseButtons.Left)
            { 
            string[] args = { lbl.Name };
          //  MessageBox.Show("");

            MainForm player = new MainForm(args);
            player.ShowDialog();
            }

            if (e.Button == MouseButtons.Right)
            {
                menu_right_button.Items.AddRange(new[] { Download_Item, Cancel_Item });
                menu_right_button.Show(MousePosition, ToolStripDropDownDirection.Right);


                old_http = lbl.Name;//Нужна для перезаписи БД


                Video.return_link(Class_Function.file_to_url(lbl.Name), 720, out cache_name, out cache_url);
            }
            // throw new NotImplementedException();
        }

        public static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_list.db");
        public void SQL_Open_video()
        {

            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            connection.Open();
            SQLiteCommand SQL_Open = new SQLiteCommand("select * FROM Table_PlayList", connection);
            SQLiteDataReader Reader_SQL_Video = SQL_Open.ExecuteReader();
            foreach (DbDataRecord record in Reader_SQL_Video)
            {
                List_Poster.Add(record["Poster"].ToString());
                List_Name.Add(record["Video"].ToString());
                List_file.Add(record["File"].ToString());
                List_url.Add(record["URL"].ToString());
            }
            connection.Close();
        }
       
        private void Kinogo_Button_Click(object sender, EventArgs e)
        {
            Form_Browser obj_kinogo = new Form_Browser();
            obj_kinogo.ShowDialog();
            List_Poster.Clear();
            List_Name.Clear();
            List_url.Clear();
            List_file.Clear();
            SQL_Open_video();
            panel1.Controls.Clear();
            create_box();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            //Удалить
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
    //Удалить
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
