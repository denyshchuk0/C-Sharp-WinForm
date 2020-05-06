namespace City
{
    partial class Citys
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citys));
            this.cbCitys = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.iLKiev = new System.Windows.Forms.ImageList(this.components);
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.iLZmerenka = new System.Windows.Forms.ImageList(this.components);
            this.iLOdesa = new System.Windows.Forms.ImageList(this.components);
            this.iLLviv = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCitys
            // 
            this.cbCitys.FormattingEnabled = true;
            this.cbCitys.Items.AddRange(new object[] {
            "Kiev",
            "Zmerenka",
            "Odessa",
            "Lviv"});
            this.cbCitys.Location = new System.Drawing.Point(70, 202);
            this.cbCitys.Name = "cbCitys";
            this.cbCitys.Size = new System.Drawing.Size(121, 21);
            this.cbCitys.TabIndex = 0;
            this.cbCitys.SelectedIndexChanged += new System.EventHandler(this.cbCitys_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 159);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // iLKiev
            // 
            this.iLKiev.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLKiev.ImageStream")));
            this.iLKiev.TransparentColor = System.Drawing.Color.Transparent;
            this.iLKiev.Images.SetKeyName(0, "1.1.jpg");
            this.iLKiev.Images.SetKeyName(1, "1.2.jpg");
            this.iLKiev.Images.SetKeyName(2, "1.3.jpeg");
            this.iLKiev.Images.SetKeyName(3, "1.jpg");
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(6, 169);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(247, 17);
            this.hScrollBar.TabIndex = 2;
            this.hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(102, 226);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(55, 13);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "linkLabel1";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 252);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(262, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // iLZmerenka
            // 
            this.iLZmerenka.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLZmerenka.ImageStream")));
            this.iLZmerenka.TransparentColor = System.Drawing.Color.Transparent;
            this.iLZmerenka.Images.SetKeyName(0, "2.1.jpg");
            this.iLZmerenka.Images.SetKeyName(1, "2.2.jpg");
            this.iLZmerenka.Images.SetKeyName(2, "2.3.jpg");
            this.iLZmerenka.Images.SetKeyName(3, "2.jpg");
            // 
            // iLOdesa
            // 
            this.iLOdesa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLOdesa.ImageStream")));
            this.iLOdesa.TransparentColor = System.Drawing.Color.Transparent;
            this.iLOdesa.Images.SetKeyName(0, "3.1.jpg");
            this.iLOdesa.Images.SetKeyName(1, "3.2.jpg");
            this.iLOdesa.Images.SetKeyName(2, "3.3.jpg");
            this.iLOdesa.Images.SetKeyName(3, "3.4.jpg");
            this.iLOdesa.Images.SetKeyName(4, "3.jpg");
            // 
            // iLLviv
            // 
            this.iLLviv.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLLviv.ImageStream")));
            this.iLLviv.TransparentColor = System.Drawing.Color.Transparent;
            this.iLLviv.Images.SetKeyName(0, "4.1.jpg");
            this.iLLviv.Images.SetKeyName(1, "4.2.jpg");
            this.iLLviv.Images.SetKeyName(2, "4.3.jpg");
            this.iLLviv.Images.SetKeyName(3, "4.4.jpg");
            this.iLLviv.Images.SetKeyName(4, "4.jpg");
            // 
            // Citys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 274);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbCitys);
            this.Name = "Citys";
            this.Text = "City";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCitys;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ImageList iLKiev;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ImageList iLZmerenka;
        private System.Windows.Forms.ImageList iLOdesa;
        private System.Windows.Forms.ImageList iLLviv;
    }
}

