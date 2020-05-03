namespace UnitForGame
{
    partial class UnitsForm
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
            this.lbWhite = new System.Windows.Forms.ListBox();
            this.lbBlack = new System.Windows.Forms.ListBox();
            this.lbUnits = new System.Windows.Forms.ListBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.btnAddWhite = new System.Windows.Forms.Button();
            this.btnSaveWhite = new System.Windows.Forms.Button();
            this.btnSaveBlack = new System.Windows.Forms.Button();
            this.btnAddBlack = new System.Windows.Forms.Button();
            this.btnPopWhite = new System.Windows.Forms.Button();
            this.btnPopBlack = new System.Windows.Forms.Button();
            this.dudTeam = new System.Windows.Forms.DomainUpDown();
            this.lWhite = new System.Windows.Forms.Label();
            this.lBlack = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.lChange = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nupUnitsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWhite
            // 
            this.lbWhite.FormattingEnabled = true;
            this.lbWhite.Location = new System.Drawing.Point(16, 24);
            this.lbWhite.Name = "lbWhite";
            this.lbWhite.Size = new System.Drawing.Size(82, 82);
            this.lbWhite.TabIndex = 0;
            // 
            // lbBlack
            // 
            this.lbBlack.FormattingEnabled = true;
            this.lbBlack.Location = new System.Drawing.Point(274, 24);
            this.lbBlack.Name = "lbBlack";
            this.lbBlack.Size = new System.Drawing.Size(87, 82);
            this.lbBlack.TabIndex = 0;
            // 
            // lbUnits
            // 
            this.lbUnits.FormattingEnabled = true;
            this.lbUnits.Location = new System.Drawing.Point(142, 11);
            this.lbUnits.Name = "lbUnits";
            this.lbUnits.Size = new System.Drawing.Size(87, 108);
            this.lbUnits.TabIndex = 1;
            
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(16, 141);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(117, 95);
            this.lbTeams.TabIndex = 2;
            // 
            // btnAddWhite
            // 
            this.btnAddWhite.Location = new System.Drawing.Point(103, 24);
            this.btnAddWhite.Name = "btnAddWhite";
            this.btnAddWhite.Size = new System.Drawing.Size(33, 40);
            this.btnAddWhite.TabIndex = 3;
            this.btnAddWhite.Text = "+";
            this.btnAddWhite.UseVisualStyleBackColor = true;
            this.btnAddWhite.Click += new System.EventHandler(this.btnAddWhite_Click);
            // 
            // btnSaveWhite
            // 
            this.btnSaveWhite.Location = new System.Drawing.Point(16, 112);
            this.btnSaveWhite.Name = "btnSaveWhite";
            this.btnSaveWhite.Size = new System.Drawing.Size(120, 23);
            this.btnSaveWhite.TabIndex = 5;
            this.btnSaveWhite.Text = "Save \"White\"";
            this.btnSaveWhite.UseVisualStyleBackColor = true;
            this.btnSaveWhite.Click += new System.EventHandler(this.btnSaveWhite_Click);
            // 
            // btnSaveBlack
            // 
            this.btnSaveBlack.Location = new System.Drawing.Point(235, 112);
            this.btnSaveBlack.Name = "btnSaveBlack";
            this.btnSaveBlack.Size = new System.Drawing.Size(126, 23);
            this.btnSaveBlack.TabIndex = 6;
            this.btnSaveBlack.Text = "Save \"Black\"";
            this.btnSaveBlack.UseVisualStyleBackColor = true;
            this.btnSaveBlack.Click += new System.EventHandler(this.btnSaveBlack_Click);
            // 
            // btnAddBlack
            // 
            this.btnAddBlack.Location = new System.Drawing.Point(235, 24);
            this.btnAddBlack.Name = "btnAddBlack";
            this.btnAddBlack.Size = new System.Drawing.Size(33, 40);
            this.btnAddBlack.TabIndex = 7;
            this.btnAddBlack.Text = "+";
            this.btnAddBlack.UseVisualStyleBackColor = true;
            this.btnAddBlack.Click += new System.EventHandler(this.btnAddBlack_Click);
            // 
            // btnPopWhite
            // 
            this.btnPopWhite.Location = new System.Drawing.Point(104, 66);
            this.btnPopWhite.Name = "btnPopWhite";
            this.btnPopWhite.Size = new System.Drawing.Size(33, 40);
            this.btnPopWhite.TabIndex = 8;
            this.btnPopWhite.Text = "-";
            this.btnPopWhite.UseVisualStyleBackColor = true;
            this.btnPopWhite.Click += new System.EventHandler(this.btnPopWhite_Click);
            // 
            // btnPopBlack
            // 
            this.btnPopBlack.Location = new System.Drawing.Point(235, 66);
            this.btnPopBlack.Name = "btnPopBlack";
            this.btnPopBlack.Size = new System.Drawing.Size(33, 40);
            this.btnPopBlack.TabIndex = 9;
            this.btnPopBlack.Text = "-";
            this.btnPopBlack.UseVisualStyleBackColor = true;
            this.btnPopBlack.Click += new System.EventHandler(this.btnPopBlack_Click);
            // 
            // dudTeam
            // 
            this.dudTeam.Items.Add("White");
            this.dudTeam.Items.Add("Black");
            this.dudTeam.Location = new System.Drawing.Point(142, 211);
            this.dudTeam.Name = "dudTeam";
            this.dudTeam.ReadOnly = true;
            this.dudTeam.Size = new System.Drawing.Size(87, 20);
            this.dudTeam.TabIndex = 11;
            this.dudTeam.Wrap = true;
            this.dudTeam.TextChanged += new System.EventHandler(this.dudTeam_TextChanged);
            // 
            // lWhite
            // 
            this.lWhite.AutoSize = true;
            this.lWhite.Location = new System.Drawing.Point(39, 8);
            this.lWhite.Name = "lWhite";
            this.lWhite.Size = new System.Drawing.Size(35, 13);
            this.lWhite.TabIndex = 12;
            this.lWhite.Text = "White";
            // 
            // lBlack
            // 
            this.lBlack.AutoSize = true;
            this.lBlack.Location = new System.Drawing.Point(297, 8);
            this.lBlack.Name = "lBlack";
            this.lBlack.Size = new System.Drawing.Size(34, 13);
            this.lBlack.TabIndex = 13;
            this.lBlack.Text = "Black";
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(157, 151);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(61, 13);
            this.lCount.TabIndex = 14;
            this.lCount.Text = "Units count";
            // 
            // lChange
            // 
            this.lChange.AutoSize = true;
            this.lChange.Location = new System.Drawing.Point(157, 195);
            this.lChange.Name = "lChange";
            this.lChange.Size = new System.Drawing.Size(60, 13);
            this.lChange.TabIndex = 15;
            this.lChange.Text = "Show team";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(235, 141);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(126, 95);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // nupUnitsCount
            // 
            this.nupUnitsCount.Location = new System.Drawing.Point(143, 167);
            this.nupUnitsCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupUnitsCount.Name = "nupUnitsCount";
            this.nupUnitsCount.Size = new System.Drawing.Size(86, 20);
            this.nupUnitsCount.TabIndex = 17;
            this.nupUnitsCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 246);
            this.Controls.Add(this.nupUnitsCount);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lChange);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.lBlack);
            this.Controls.Add(this.lWhite);
            this.Controls.Add(this.dudTeam);
            this.Controls.Add(this.btnPopBlack);
            this.Controls.Add(this.btnPopWhite);
            this.Controls.Add(this.btnAddBlack);
            this.Controls.Add(this.btnSaveBlack);
            this.Controls.Add(this.btnSaveWhite);
            this.Controls.Add(this.btnAddWhite);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.lbUnits);
            this.Controls.Add(this.lbBlack);
            this.Controls.Add(this.lbWhite);
            this.Name = "UnitsForm";
            this.Text = "Enter Unit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWhite;
        private System.Windows.Forms.ListBox lbBlack;
        private System.Windows.Forms.ListBox lbUnits;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.Button btnAddWhite;
        private System.Windows.Forms.Button btnSaveWhite;
        private System.Windows.Forms.Button btnSaveBlack;
        private System.Windows.Forms.Button btnAddBlack;
        private System.Windows.Forms.Button btnPopWhite;
        private System.Windows.Forms.Button btnPopBlack;
        private System.Windows.Forms.DomainUpDown dudTeam;
        private System.Windows.Forms.Label lWhite;
        private System.Windows.Forms.Label lBlack;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lChange;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown nupUnitsCount;
    }
}

