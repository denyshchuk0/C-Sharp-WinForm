﻿namespace EXAM
{
    partial class ChildForm
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
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.textTest = new System.Windows.Forms.Label();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.textTest);
            this.groupBoxTest.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(434, 88);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "question";
            // 
            // textTest
            // 
            this.textTest.AutoSize = true;
            this.textTest.Location = new System.Drawing.Point(27, 30);
            this.textTest.Name = "textTest";
            this.textTest.Size = new System.Drawing.Size(29, 13);
            this.textTest.TabIndex = 0;
            this.textTest.Text = "label";
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.checkedListBox);
            this.groupBoxAnswer.Location = new System.Drawing.Point(13, 107);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(531, 154);
            this.groupBoxAnswer.TabIndex = 1;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Choose the correct answer";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(519, 124);
            this.checkedListBox.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(453, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 88);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 287);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBoxAnswer);
            this.Controls.Add(this.groupBoxTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChildForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBoxAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Label textTest;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}