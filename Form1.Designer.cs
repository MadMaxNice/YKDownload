namespace MaterialSkinExample
{
    partial class Form_Browser
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
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_close = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.Items.AddRange(new object[] {
            "Биографии",
            "Боевики",
            "Вестерны",
            "Военные",
            "Детективы",
            "Детские",
            "Документальные",
            "Драмы",
            "Исторические",
            "Комедии",
            "Криминал",
            "Мелодрамы",
            "Мультфильмы",
            "Мюзиклы",
            "Отечественные",
            "Приключения",
            "Семейные",
            "Спортивные",
            "Триллеры",
            "Ужасы",
            "Фантастика",
            "Фэнтэзи"});
            this.comboBox_Genre.Location = new System.Drawing.Point(724, 674);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(195, 21);
            this.comboBox_Genre.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(925, 674);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 610);
            this.panel1.TabIndex = 3;
            // 
            // Button_close
            // 
            this.Button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_close.AutoSize = true;
            this.Button_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_close.CausesValidation = false;
            this.Button_close.Depth = 0;
            this.Button_close.Icon = null;
            this.Button_close.Location = new System.Drawing.Point(977, 24);
            this.Button_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_close.Name = "Button_close";
            this.Button_close.Primary = true;
            this.Button_close.Size = new System.Drawing.Size(63, 36);
            this.Button_close.TabIndex = 4;
            this.Button_close.Text = "Close";
            this.Button_close.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Form_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1042, 682);
            this.ControlBox = false;
            this.Controls.Add(this.Button_close);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox_Genre);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Browser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton Button_close;
        private System.Windows.Forms.Timer timer1;
    }
}