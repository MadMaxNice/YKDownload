using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.FullScreenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.text_url_youtube = new System.Windows.Forms.TextBox();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label_duration_track = new MaterialSkin.Controls.MaterialLabel();
            this.label_duration_current = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_pause_to_play = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_playlist = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Label_Title = new MaterialSkin.Controls.MaterialLabel();
            this.Play_Box_List = new MetroFramework.Controls.MetroComboBox();
            this.ComboBox_Series = new MetroFramework.Controls.MetroComboBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PauseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PlayButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_list_fim = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 461);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(625, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.CausesValidation = false;
            this.materialRadioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(0, 420);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(60, 30);
            this.materialRadioButton1.TabIndex = 9;
            this.materialRadioButton1.Text = "360p";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenButton.AutoSize = true;
            this.FullScreenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FullScreenButton.CausesValidation = false;
            this.FullScreenButton.Depth = 0;
            this.FullScreenButton.Icon = null;
            this.FullScreenButton.Location = new System.Drawing.Point(503, 422);
            this.FullScreenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Primary = true;
            this.FullScreenButton.Size = new System.Drawing.Size(107, 36);
            this.FullScreenButton.TabIndex = 0;
            this.FullScreenButton.Text = "Full Screen";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // text_url_youtube
            // 
            this.text_url_youtube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_url_youtube.CausesValidation = false;
            this.text_url_youtube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_url_youtube.Location = new System.Drawing.Point(56, 475);
            this.text_url_youtube.Multiline = true;
            this.text_url_youtube.Name = "text_url_youtube";
            this.text_url_youtube.Size = new System.Drawing.Size(469, 20);
            this.text_url_youtube.TabIndex = 25;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.CausesValidation = false;
            this.materialRadioButton2.Checked = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(60, 420);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(60, 30);
            this.materialRadioButton2.TabIndex = 27;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "720p";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // label_duration_track
            // 
            this.label_duration_track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_duration_track.AutoSize = true;
            this.label_duration_track.Depth = 0;
            this.label_duration_track.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_duration_track.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_duration_track.Location = new System.Drawing.Point(545, 388);
            this.label_duration_track.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_duration_track.Name = "label_duration_track";
            this.label_duration_track.Size = new System.Drawing.Size(65, 19);
            this.label_duration_track.TabIndex = 30;
            this.label_duration_track.Text = "00:00:00";
            this.label_duration_track.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_duration_current
            // 
            this.label_duration_current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_duration_current.AutoSize = true;
            this.label_duration_current.Depth = 0;
            this.label_duration_current.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_duration_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_duration_current.Location = new System.Drawing.Point(2, 387);
            this.label_duration_current.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_duration_current.Name = "label_duration_current";
            this.label_duration_current.Size = new System.Drawing.Size(65, 19);
            this.label_duration_current.TabIndex = 31;
            this.label_duration_current.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer_pause_to_play
            // 
            this.timer_pause_to_play.Interval = 500;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.CausesValidation = false;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(617, 304);
            this.axWindowsMediaPlayer1.TabIndex = 28;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 365);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(617, 45);
            this.trackBar1.TabIndex = 32;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // button_playlist
            // 
            this.button_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_playlist.AutoSize = true;
            this.button_playlist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_playlist.CausesValidation = false;
            this.button_playlist.Depth = 0;
            this.button_playlist.Icon = null;
            this.button_playlist.Location = new System.Drawing.Point(524, 25);
            this.button_playlist.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_playlist.Name = "button_playlist";
            this.button_playlist.Primary = true;
            this.button_playlist.Size = new System.Drawing.Size(83, 36);
            this.button_playlist.TabIndex = 34;
            this.button_playlist.Text = "Playlist";
            this.button_playlist.UseVisualStyleBackColor = true;
            this.button_playlist.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Depth = 0;
            this.Label_Title.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Title.Location = new System.Drawing.Point(12, 74);
            this.Label_Title.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(127, 19);
            this.Label_Title.TabIndex = 35;
            this.Label_Title.Text = "Название видео";
            // 
            // Play_Box_List
            // 
            this.Play_Box_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Play_Box_List.FormattingEnabled = true;
            this.Play_Box_List.ItemHeight = 23;
            this.Play_Box_List.Location = new System.Drawing.Point(112, 29);
            this.Play_Box_List.Name = "Play_Box_List";
            this.Play_Box_List.Size = new System.Drawing.Size(351, 29);
            this.Play_Box_List.Style = MetroFramework.MetroColorStyle.Red;
            this.Play_Box_List.TabIndex = 36;
            this.Play_Box_List.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Play_Box_List.UseSelectable = true;
            // 
            // ComboBox_Series
            // 
            this.ComboBox_Series.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Series.FormattingEnabled = true;
            this.ComboBox_Series.ItemHeight = 23;
            this.ComboBox_Series.Location = new System.Drawing.Point(460, 29);
            this.ComboBox_Series.Name = "ComboBox_Series";
            this.ComboBox_Series.Size = new System.Drawing.Size(58, 29);
            this.ComboBox_Series.TabIndex = 37;
            this.ComboBox_Series.UseSelectable = true;
            this.ComboBox_Series.Visible = false;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.CausesValidation = false;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = global::MaterialSkinExample.Properties.Resources.download;
            this.materialRaisedButton3.Location = new System.Drawing.Point(6, 470);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(44, 36);
            this.materialRaisedButton3.TabIndex = 26;
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PauseButton.AutoSize = true;
            this.PauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PauseButton.CausesValidation = false;
            this.PauseButton.Depth = 0;
            this.PauseButton.Icon = global::MaterialSkinExample.Properties.Resources.pause;
            this.PauseButton.Location = new System.Drawing.Point(313, 420);
            this.PauseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Primary = true;
            this.PauseButton.Size = new System.Drawing.Size(44, 36);
            this.PauseButton.TabIndex = 24;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.CausesValidation = false;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = global::MaterialSkinExample.Properties.Resources.plus;
            this.materialRaisedButton2.Location = new System.Drawing.Point(535, 468);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "Add";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayButton.AutoSize = true;
            this.PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayButton.CausesValidation = false;
            this.PlayButton.Depth = 0;
            this.PlayButton.Icon = global::MaterialSkinExample.Properties.Resources.play;
            this.PlayButton.Location = new System.Drawing.Point(263, 420);
            this.PlayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Primary = true;
            this.PlayButton.Size = new System.Drawing.Size(44, 36);
            this.PlayButton.TabIndex = 23;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // button_list_fim
            // 
            this.button_list_fim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_list_fim.AutoSize = true;
            this.button_list_fim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_list_fim.CausesValidation = false;
            this.button_list_fim.Depth = 0;
            this.button_list_fim.Icon = global::MaterialSkinExample.Properties.Resources.minus;
            this.button_list_fim.Location = new System.Drawing.Point(442, 422);
            this.button_list_fim.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_list_fim.Name = "button_list_fim";
            this.button_list_fim.Primary = true;
            this.button_list_fim.Size = new System.Drawing.Size(44, 36);
            this.button_list_fim.TabIndex = 38;
            this.button_list_fim.UseVisualStyleBackColor = true;
            this.button_list_fim.Click += new System.EventHandler(this.button_list_fim_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 511);
            this.Controls.Add(this.Play_Box_List);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label_duration_current);
            this.Controls.Add(this.label_duration_track);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.text_url_youtube);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button_playlist);
            this.Controls.Add(this.button_list_fim);
            this.Controls.Add(this.ComboBox_Series);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Text = "Video player";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialDivider materialDivider1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialRadioButton materialRadioButton1;
        private MaterialRaisedButton FullScreenButton;
       // private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MaterialRaisedButton PlayButton;
        private MaterialRaisedButton PauseButton;
        private MaterialRaisedButton materialRaisedButton3;
        private MaterialRadioButton materialRadioButton2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MaterialLabel label_duration_track;
        private MaterialLabel label_duration_current;
        private Timer timer1;
        private Timer timer_pause_to_play;
        public TextBox text_url_youtube;
		private TrackBar trackBar1;
		private MaterialRaisedButton button_playlist;
		private MaterialLabel Label_Title;
		private MetroFramework.Controls.MetroComboBox Play_Box_List;
		private MetroFramework.Controls.MetroComboBox ComboBox_Series;
        private MaterialRaisedButton button_list_fim;
    }
}