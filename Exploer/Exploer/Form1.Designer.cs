namespace Exploer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(47, 13);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(626, 20);
            this.tbPath.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(679, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 49);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(743, 389);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(100, 26);
            this.contextMenuStrip.Click += new System.EventHandler(this.contextMenuStrip_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deToolStripMenuItem,
            this.largeIconToolStripMenuItem1,
            this.listToolStripMenuItem1,
            this.smallIconToolStripMenuItem1,
            this.tileToolStripMenuItem1});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.detailsToolStripMenuItem.Text = "View";
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deToolStripMenuItem.Text = "Details";
            // 
            // largeIconToolStripMenuItem1
            // 
            this.largeIconToolStripMenuItem1.Name = "largeIconToolStripMenuItem1";
            this.largeIconToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.largeIconToolStripMenuItem1.Text = "LargeIcon";
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem1.Text = "List";
            // 
            // smallIconToolStripMenuItem1
            // 
            this.smallIconToolStripMenuItem1.Name = "smallIconToolStripMenuItem1";
            this.smallIconToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.smallIconToolStripMenuItem1.Text = "SmallIcon";
            // 
            // tileToolStripMenuItem1
            // 
            this.tileToolStripMenuItem1.Name = "tileToolStripMenuItem1";
            this.tileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tileToolStripMenuItem1.Text = "Tile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem1;
    }
}

