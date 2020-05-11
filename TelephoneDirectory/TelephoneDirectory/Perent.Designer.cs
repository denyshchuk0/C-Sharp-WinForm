namespace TelephoneDirectory
{
    partial class Perent
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
            this.lNumber = new System.Windows.Forms.Label();
            this.lbCatalog = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAllDelete = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(12, 9);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(0, 13);
            this.lNumber.TabIndex = 5;
            // 
            // lbCatalog
            // 
            this.lbCatalog.FormattingEnabled = true;
            this.lbCatalog.Location = new System.Drawing.Point(159, 1);
            this.lbCatalog.Name = "lbCatalog";
            this.lbCatalog.Size = new System.Drawing.Size(194, 173);
            this.lbCatalog.TabIndex = 4;
            this.lbCatalog.SelectedValueChanged += new System.EventHandler(this.lbCatalog_SelectedValueChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(12, 178);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(89, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAllDelete
            // 
            this.btnAllDelete.Location = new System.Drawing.Point(263, 178);
            this.btnAllDelete.Name = "btnAllDelete";
            this.btnAllDelete.Size = new System.Drawing.Size(90, 23);
            this.btnAllDelete.TabIndex = 9;
            this.btnAllDelete.Text = "Delete All";
            this.btnAllDelete.UseVisualStyleBackColor = true;
            this.btnAllDelete.Click += new System.EventHandler(this.btnAllDelete_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(129, 115);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(141, 147);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Perent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 213);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAllDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.lbCatalog);
            this.Name = "Perent";
            this.Text = "directory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.ListBox lbCatalog;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAllDelete;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

