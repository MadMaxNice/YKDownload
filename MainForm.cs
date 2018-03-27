using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using YoutubeExtractor;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.Data.Common;
using System.Data.SQLite;
using My_Download;
namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        string[] args;
        public int stH = 0;
        public int stW = 0;
        public int stTop = 0;
        public int resol=144;
        public double current_time=0;
        public string temp_url = "";
        public bool FullScreen = false;
        public bool trackbar_down = false;
		private string Title = "";
		private List<string> Url;
		private readonly MaterialSkinManager materialSkinManager;
		//  public Form_button obj_youtube_button = new Form_button();
		public MainForm(string[] args)
		{
			this.args = args;
			InitializeComponent();
			Class_Function.SQL_Playlist(Play_Box_List);
			Play_Box_List.SelectedIndex = Play_Box_List.Items.Count - 1;
			if (args.Length > 0)
			{
				text_url_youtube.Text = args[0];
				text_url_youtube.Text = text_url_youtube.Text.Replace("madmaxniceyoutube:", "");
				my_play(text_url_youtube.Text);
			//	SQL_ADD_VIDEO(text_url_youtube.Text, Label_Title.Text);
				text_url_youtube.Text = "";
			}
			KeyPreview = true;
			this.KeyDown += MainForm_KeyDown;
			axWindowsMediaPlayer1.MouseDownEvent += AxWindowsMediaPlayer1_MouseDownEvent;
			//
			Play_Box_List.SelectedValueChanged += Play_Box_List_SelectedValueChanged;
			//
			ComboBox_Series.SelectedIndexChanged += ComboBox_Series_SelectedIndexChanged;
			trackBar1.MouseUp += TrackBar1_MouseUp;
			trackBar1.MouseDown += TrackBar1_MouseDown;
			trackBar1.ValueChanged += TrackBar1_ValueChanged;
			// Initialize MaterialSkinManager
			materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red900, Primary.Indigo100, Accent.Pink200, TextShade.BLACK);
			// WindowState = FormWindowState.Maximized;
			axWindowsMediaPlayer1.stretchToFit = true;
			seedListView();
			stH = axWindowsMediaPlayer1.Height;
			stW = axWindowsMediaPlayer1.Width;
			stTop = axWindowsMediaPlayer1.Top;
			timer1.Tick += Timer1_Tick;
			timer_pause_to_play.Tick += Timer_pause_to_play_Tick;
            this.FormClosing += MainForm_FormClosing;
			//axWindowsMediaPlayer1.URL = Url[0];
			//     axWindowsMediaPlayer1.URL = "http://m-m1-05-adww.kinogo.club/9f99fcce5c9d562d28a89ec3a2e5f719_OTMuODQuMTMwLjIx/films/hq5/stena-2017.flv";//"https://r2---sn-n8v7zner.googlevideo.com/videoplayback?itag=22&expire=1500726381&ratebypass=yes&ms=au&ei=DfByWejYE5TEYPnyjtAM&mv=m&mt=1500704681&pl=46&ip=2a05%3A7e83%3A4%3A10e%3A1c3a%3A7f87%3A534e%3Aed21&id=o-ADTooQ_Kat1lOyXu40avcj84PN_Yg2xVQmuAObuBJEoZ&mn=sn-n8v7zner&mm=31&mime=video%2Fmp4&sparams=dur%2Cei%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cnh%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cexpire&initcwndbps=2863750&ipbits=0&lmt=1500502532369351&dur=1731.790&source=youtube&requiressl=yes&signature=05A41984A5E6EEFA3BD1C8A2FDFB932D93C14D61.9D333EBC76E423CFABAC785EBBA1740BBDC93A42&key=yt6&nh=IgpwcjAzLnN2bzA1KgkxMjcuMC4wLjE&title=%D0%9D%D0%B0%D0%B2%D0%B0%D0%BB%D0%B8%D0%BB+%D0%BD%D0%B0+%D1%82%D0%B0%D1%87%D0%BA%D0%B5+%D0%B1%D0%BE%D1%81%D1%81%D0%B0+-+%D0%BF%D1%80%D0%BE%D1%85%D0%BE%D0%B6%D0%B4%D0%B5%D0%BD%D0%B8%D0%B5+Need+for+Speed+Most+Wanted+%D0%BD%D0%B0+%D1%80%D1%83%D0%BB%D0%B5+Fanatec+CSLElite+PS4";
		}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
           // throw new NotImplementedException();
        }

        private void ComboBox_Series_SelectedIndexChanged(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = Url[ComboBox_Series.SelectedIndex];
		}

		private void Play_Box_List_SelectedValueChanged(object sender, EventArgs e)
		{
			//	MessageBox.Show(Play_Box_List.SelectedItem.ToString());
				my_play(Class_Function.SQL_Open_video(Play_Box_List.SelectedItem.ToString()));
		}
	

		private void TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
    
          trackbar_down = true;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;

            //throw new NotImplementedException();
        }

        private void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;
            trackbar_down = false;

            //throw new NotImplementedException();
        }

        bool setting = false;
        private void AxWindowsMediaPlayer1_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            if(FullScreen==true)
            if (e.nButton == 2)
            {
                switch(setting)
                {
                    case false:
                    FullScreen_interface(false);
                        setting = true;
                        break;
                    case true:
                        FullScreen_interface(true);
                        setting = false;
                        break;
                }
            }
        } 
        private void Timer_pause_to_play_Tick(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying ||
                axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused ||
                axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady)          
            {     
                label_duration_current.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                trackBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                label_duration_track.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                if (trackbar_down==false)
                    trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            // timer1.Start();
           // if (checkbox_browser.Checked == true) { obj_youtube_button.Visible = true; }
          //  if (checkbox_browser.Checked == false) { obj_youtube_button.Visible=false; }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            
            //axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;
           // axWindowsMediaPlayer1.Ctlcontrols.pause();
          //  Thread.Sleep(200);/*Костыль*/
       
            // label_duration_current.Text = trackBar1.Value.ToString();
            //  label_duration_current.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) my_Escape();
           
         
        }
        public void my_Escape()
        {
            WindowState = FormWindowState.Normal;
            //     this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TopMost = false;
            axWindowsMediaPlayer1.Width = stW;
            axWindowsMediaPlayer1.Height = stH;
            axWindowsMediaPlayer1.Top = stTop;
			My_BringToFrong();
			FullScreen = false;
        }
		void My_BringToFrong()
		{
			trackBar1.BringToFront();
			PlayButton.BringToFront();
			PauseButton.BringToFront();
			label_duration_current.BringToFront();
			label_duration_track.BringToFront();
			button_playlist.BringToFront();
			Play_Box_List.BringToFront();
			Label_Title.BringToFront();
			button_list_fim.BringToFront();
			ComboBox_Series.BringToFront();
		}
		void My_SendToBack()
		{
			trackBar1.SendToBack();
			PlayButton.SendToBack();
			PauseButton.SendToBack();
			label_duration_current.SendToBack();
			label_duration_track.SendToBack();
			button_playlist.SendToBack();
			Play_Box_List.SendToBack();
			Label_Title.SendToBack();
			button_list_fim.SendToBack();
			ComboBox_Series.SendToBack();
		}
		private void seedListView()
	    {
			//Define
			var data = new[]
	        {
		        new []{"Lollipop", "392", "0.2", "0"},
				new []{"KitKat", "518", "26.0", "7"},
				new []{"Ice cream sandwich", "237", "9.0", "4.3"},
				new []{"Jelly Bean", "375", "0.0", "0.0"},
				new []{"Honeycomb", "408", "3.2", "6.5"}
	        };

			//Add
			foreach (string[] version in data)
			{
				var item = new ListViewItem(version);
				//materialListView1.Items.Add(item);
			}
        }
        //Кнопки для полноэкранного режима
        public void FullScreen_interface(bool Full)
        {
            switch (Full)
            {
                case false:
					My_BringToFrong();
					break;
                case true:
					My_SendToBack();
					break;
            }

        }

    

        private void materialButton1_Click(object sender, EventArgs e)
        {    
				{
                FullScreen = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                Height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
                Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
                  axWindowsMediaPlayer1.Height = Height;
                 axWindowsMediaPlayer1.Width = Width;
                axWindowsMediaPlayer1.Top = 0;
				My_SendToBack();
				// axWindowsMediaPlayer1.fullScreen = true;
			}

        }

	    private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
	        colorSchemeIndex++;
	        if (colorSchemeIndex > 2) colorSchemeIndex = 0;

			//These are just example color schemes
	        switch (colorSchemeIndex)
	        {
				case 0:
					materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			        break;
				case 1:
					materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
			        break;
				case 2:
					materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
					break;
	        }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            my_play(text_url_youtube.Text);
			//SQL_ADD_VIDEO(text_url_youtube.Text, Label_Title.Text);
        }
/// <summary>
/// </summary>
/// <param name="URL"></param>
		public void my_play(string URL)
        {
		try
		{
		ComboBox_Series.Visible = false;
		ComboBox_Series.Items.Clear();
		current_time = 0;
		if (materialRadioButton1.Checked == true) resol = 360;
		if (materialRadioButton2.Checked == true) resol = 720;
		Video.return_link(URL, resol, out Title, out Url);
		Label_Title.Text = Title;
				//MessageBox.Show(ToString());
				for (int i = 0; i < Url.Count; i++)
				{
					ComboBox_Series.Items.Add(i+1);
				}
				if (ComboBox_Series.Items.Count> 1)
				{
					ComboBox_Series.Visible = true;
				}
				ComboBox_Series.SelectedIndex = 0;
				//MessageBox.Show(Url[ComboBox_Series.SelectedIndex]);
				axWindowsMediaPlayer1.URL = Url[ComboBox_Series.SelectedIndex];
               // MessageBox.Show("Серия"+Url[1]);
            }
		catch 
		{
	MessageBox.Show("Данное видео уже имеется в плейлисте");
		}
		}
		public void SQL_ADD_VIDEO(string URL,string Title)
		{
			
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", Class_Function.dbPath));
			connection.Open();
			using (SQLiteCommand SQL_Playlist = new SQLiteCommand("insert into Table_Playlist (URL, Video) values (@URL, @Name_Video)", connection))
			{
				SQL_Playlist.Parameters.AddWithValue("@URL", URL);
				SQL_Playlist.Parameters.AddWithValue("@Name_Video", Title);
				SQL_Playlist.ExecuteNonQuery();
			}
			connection.Close();
			Play_Box_List.Items.Clear();
			Class_Function.SQL_Playlist(Play_Box_List);
		}


		private void materialFlatButton4_Click(object sender, EventArgs e)
        {
          //  materialProgressBar1.Value = Math.Max(materialProgressBar1.Value - 10, 0);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
         
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            //    PlayButton.Visible = false;
            //    PauseButton.Visible = true;
            }
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
          
         
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
               
                //   PauseButton.Visible = false;
                // PlayButton.Visible = true;
            }
        }
        private void change_resolution()
        {
            current_time = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            if (temp_url.Length!=0)
            {
                if (materialRadioButton1.Checked == true) resol = 360;
                if (materialRadioButton2.Checked == true) resol = 720;
				//  axWindowsMediaPlayer1.URL = video.DownloadUrl.ToString();
				MessageBox.Show("Этот метод временно отключен");
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = current_time;
            }
        }
        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            change_resolution();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            change_resolution();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

		private void materialRaisedButton1_Click_1(object sender, EventArgs e)
		{
			if (Play_Box_List.Visible == true)
			{
				Play_Box_List.Visible = false;
				return;
			}
			if (Play_Box_List.Visible == false)
			{
				Play_Box_List.Visible = true;
				return;
			}
		}

        private void button_list_fim_Click(object sender, EventArgs e)
        {
           // Form1 list_film = new Form1();
          //  list_film.Show();
        }
    }
}
