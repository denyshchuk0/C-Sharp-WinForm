using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor3000
{
    public partial class TEdit : Form
    {
        string filters = "Text Files|*.txt|RTF|*.rtf|C# Files|*.cs|All Files|*.*";

        bool save = false;
        bool bold = false;
        bool italic = false;
        bool underline = false;

        string path = "";
        public TEdit()
        {
            InitializeComponent();
            openFileDialog.Filter = filters; //include filtres
            saveFileDialog.Filter = filters;
            richTextBox.ContextMenuStrip = contextMenuStrip;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessegeSaveFile();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                path = openFileDialog.FileName;
                save = true;
            }
        }

        private void MessegeSaveFile() // there is using massegeBox (Sorry!) for sove
        {
            if (!String.IsNullOrWhiteSpace(richTextBox.Text) && !save)
            {
                DialogResult result = MessageBox.Show("File is not saved\nSave?", $"Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    saveAsToolStripMenuItem_Click(null, null);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                if (saveFileDialog.FileName.Length > 0)
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    path = saveFileDialog.FileName;
                    save = true;
                }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SaveFile(path, RichTextBoxStreamType.PlainText);
            save = true;
        }
        //lamda!!!!!
        private void richTextBox_TextChanged(object sender, EventArgs e) => save = false;
        private void TEdit_FormClosing(object sender, FormClosingEventArgs e) => MessegeSaveFile();

        private void ChangeFontStyle(ref bool state, ref bool flag1, ref bool flag2, FontStyle fontStyle)
        {
            if (!state)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, fontStyle);
                state = true;
            }
            else
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular);
                state = false;
            }
            flag1 = flag2 = false;
            Active();
        }

        private void Active()
        { //this needs for note а стоп я ж можу укр писати)
            // цей метод відмічає задіяні елементи
            tSBold.BackColor = Control.DefaultBackColor; 
            tSItalics.BackColor = Control.DefaultBackColor;
            tSUnderline.BackColor = Control.DefaultBackColor;

            if (bold)
                tSBold.BackColor = Color.LightGray;
            else if (italic)
                tSItalics.BackColor = Color.LightGray;
            else if (underline)
                tSUnderline.BackColor = Color.LightGray;
        }
        //lamda FOREVER!!!!!
        private void tSBold_Click(object sender, EventArgs e) =>
            ChangeFontStyle(ref bold, ref italic, ref underline, FontStyle.Bold);
        private void tSItalics_Click(object sender, EventArgs e) =>
            ChangeFontStyle(ref italic, ref bold, ref underline, FontStyle.Italic);
        private void tSUnderline_Click(object sender, EventArgs e) =>
            ChangeFontStyle(ref underline, ref bold, ref italic, FontStyle.Underline);

        private void tSRight_Click(object sender, EventArgs e) =>
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        private void tSCenter_Click(object sender, EventArgs e) =>
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        private void tSLeft_Click(object sender, EventArgs e) =>
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Paste();

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength != 0) //мене часом дістає що я можу скопіювати пусту область, тому тут if
                richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength != 0)
                richTextBox.Copy();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.SelectAll();
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Clear();
        private void tSFontSize_Click(object sender, EventArgs e) => fontDialog.ShowDialog();

        private void tSFontColor_Click(object sender, EventArgs e)
        {//MSDN но тут все понятно, привязуємо вибір кольору і, влесне, вибираємо
            colorDialog.Color = richTextBox.SelectionColor;
            if (colorDialog.ShowDialog() == DialogResult.OK && colorDialog.Color != richTextBox.SelectionColor)
                richTextBox.SelectionColor = colorDialog.Color;
        }

        private void tSFontBackground_Click(object sender, EventArgs e)
        {
            colorDialog.Color = richTextBox.SelectionBackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK && colorDialog.Color != richTextBox.SelectionBackColor)
                richTextBox.SelectionBackColor = colorDialog.Color;
        }

        private void tSListOffOn_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionBullet == false)
                richTextBox.SelectionBullet = true;
            else
                richTextBox.SelectionBullet = false;
        }

        private void tSFontSizeUp_Click(object sender, EventArgs e)
        {
            Font font = richTextBox.SelectionFont;
            if (richTextBox.SelectionLength != 0 && font.Size <= 72)
                richTextBox.SelectionFont = new Font(font.FontFamily, font.Size + 2);
        }

        private void tSFontSizeDown_Click(object sender, EventArgs e)
        {
            Font font = richTextBox.SelectionFont;
            if (richTextBox.SelectionLength != 0 && font.Size >= 2)
                richTextBox.SelectionFont = new Font(font.FontFamily, font.Size - 2);
        }
    }
}
