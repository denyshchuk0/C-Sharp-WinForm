namespace TaskMaster
{
    partial class TaskManager
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
            this.textTask = new System.Windows.Forms.TextBox();
            this.textEvent = new System.Windows.Forms.TextBox();
            this.lbTask = new System.Windows.Forms.Label();
            this.lbEvent = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.textPriority = new System.Windows.Forms.TextBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClaer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textTask
            // 
            this.textTask.Location = new System.Drawing.Point(29, 27);
            this.textTask.Multiline = true;
            this.textTask.Name = "textTask";
            this.textTask.Size = new System.Drawing.Size(289, 61);
            this.textTask.TabIndex = 0;
            // 
            // textEvent
            // 
            this.textEvent.Location = new System.Drawing.Point(29, 125);
            this.textEvent.Name = "textEvent";
            this.textEvent.Size = new System.Drawing.Size(289, 20);
            this.textEvent.TabIndex = 1;
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Location = new System.Drawing.Point(29, 11);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(55, 13);
            this.lbTask.TabIndex = 1;
            this.lbTask.Text = "Enter task";
            this.lbTask.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Location = new System.Drawing.Point(29, 109);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(90, 13);
            this.lbEvent.TabIndex = 1;
            this.lbEvent.Text = "Enter plase event";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 187);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 9, 14, 34, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(29, 171);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(56, 13);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Enter date";
            // 
            // textPriority
            // 
            this.textPriority.Location = new System.Drawing.Point(29, 246);
            this.textPriority.Name = "textPriority";
            this.textPriority.Size = new System.Drawing.Size(289, 20);
            this.textPriority.TabIndex = 3;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Location = new System.Drawing.Point(29, 230);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(65, 13);
            this.lbPriority.TabIndex = 1;
            this.lbPriority.Text = "Enter priority";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseDown);
            // 
            // btnClaer
            // 
            this.btnClaer.Location = new System.Drawing.Point(173, 303);
            this.btnClaer.Name = "btnClaer";
            this.btnClaer.Size = new System.Drawing.Size(75, 57);
            this.btnClaer.TabIndex = 3;
            this.btnClaer.Text = "Clear";
            this.btnClaer.UseVisualStyleBackColor = true;
            this.btnClaer.Click += new System.EventHandler(this.btnClaer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 57);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(369, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(221, 238);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 407);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClaer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPriority);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.textPriority);
            this.Controls.Add(this.textEvent);
            this.Controls.Add(this.textTask);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTask;
        private System.Windows.Forms.TextBox textEvent;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox textPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClaer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBox;
    }
}

