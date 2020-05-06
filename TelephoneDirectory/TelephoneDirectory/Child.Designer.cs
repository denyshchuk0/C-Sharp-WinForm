namespace TelephoneDirectory
{
    partial class Child
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnEnterPicture = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 170);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(13, 209);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ShortcutsEnabled = false;
            this.tbNumber.Size = new System.Drawing.Size(128, 20);
            this.tbNumber.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(129, 115);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 151);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(14, 193);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(44, 13);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "Number";
            // 
            // btnEnterPicture
            // 
            this.btnEnterPicture.Location = new System.Drawing.Point(12, 122);
            this.btnEnterPicture.Name = "btnEnterPicture";
            this.btnEnterPicture.Size = new System.Drawing.Size(129, 26);
            this.btnEnterPicture.TabIndex = 3;
            this.btnEnterPicture.Text = "Enter photo";
            this.btnEnterPicture.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 26);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 268);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEnterPicture);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbName);
            this.Name = "Child";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Child_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Button btnEnterPicture;
        private System.Windows.Forms.Button btnSave;
    }
}