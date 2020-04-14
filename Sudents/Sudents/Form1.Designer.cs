namespace Sudents
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbAge = new System.Windows.Forms.Label();
            this.textHobby = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(141, 20);
            this.textName.TabIndex = 0;
            this.textName.Text = "Name";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(12, 38);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(141, 20);
            this.textSurname.TabIndex = 1;
            this.textSurname.Text = "Surname";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 65);
            this.dateTimePicker.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1919, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 9, 0, 0, 0, 0);
            this.dateTimePicker.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // lbAge
            // 
            this.lbAge.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAge.Location = new System.Drawing.Point(159, 65);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(120, 20);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // textHobby
            // 
            this.textHobby.Location = new System.Drawing.Point(12, 122);
            this.textHobby.Name = "textHobby";
            this.textHobby.Size = new System.Drawing.Size(141, 20);
            this.textHobby.TabIndex = 4;
            this.textHobby.Text = "Hobby";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(12, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(159, 148);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 40);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Last";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox.Location = new System.Drawing.Point(12, 91);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(141, 21);
            this.comboBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(291, 200);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textHobby);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quetionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox textHobby;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

