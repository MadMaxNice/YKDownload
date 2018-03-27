namespace MaterialSkinExample
{
    partial class Form_PlayList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.close_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Kinogo_Button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 610);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.close_button);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Location = new System.Drawing.Point(174, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.AutoSize = true;
            this.close_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close_button.CausesValidation = false;
            this.close_button.Depth = 0;
            this.close_button.Icon = null;
            this.close_button.Location = new System.Drawing.Point(547, 18);
            this.close_button.MaximumSize = new System.Drawing.Size(53, 16);
            this.close_button.MinimumSize = new System.Drawing.Size(53, 16);
            this.close_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.close_button.Name = "close_button";
            this.close_button.Primary = true;
            this.close_button.Size = new System.Drawing.Size(53, 16);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(302, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Кэширование. Пожалуйста, подождите...";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // Kinogo_Button
            // 
            this.Kinogo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kinogo_Button.AutoSize = true;
            this.Kinogo_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kinogo_Button.CausesValidation = false;
            this.Kinogo_Button.Depth = 0;
            this.Kinogo_Button.Icon = null;
            this.Kinogo_Button.Location = new System.Drawing.Point(912, 27);
            this.Kinogo_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Kinogo_Button.Name = "Kinogo_Button";
            this.Kinogo_Button.Primary = true;
            this.Kinogo_Button.Size = new System.Drawing.Size(138, 36);
            this.Kinogo_Button.TabIndex = 2;
            this.Kinogo_Button.Text = "Kinogo Browser";
            this.Kinogo_Button.UseVisualStyleBackColor = true;
            this.Kinogo_Button.Click += new System.EventHandler(this.Kinogo_Button_Click);
            // 
            // Form_PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 700);
            this.Controls.Add(this.Kinogo_Button);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_PlayList";
            this.Text = "Плейлист";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton Kinogo_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton close_button;
    }
}