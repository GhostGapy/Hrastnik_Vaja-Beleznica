using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beleznica
{
    public partial class Form1 : Form
    {
        string filename = "untitled";
        public Form1()
        {
            InitializeComponent();
        }
        void ChangeFilename(string newFilename)
        {
            filename = newFilename;
            this.Text = "Note - "+filename;
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //richTextBox1.Clear();
            ChangeFilename("untitled");
        }

        void savefile(string fname)
        {
            try
            {
                richTextBox1.SaveFile(fname);
                ChangeFilename(fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (filename == "untitled")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                    savefile(filename);
                }
            }
            else
            {
                savefile(filename);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                try
                {
                    richTextBox1.LoadFile(filename);
                    ChangeFilename(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            bool bold;
            if(sender ==boldToolStripButton)
            {
                bold = boldToolStripButton.Checked;
                boldToolStripMenuItem.Checked = bold;
            }
            else
            {
                bold = boldToolStripMenuItem.Checked;
                boldToolStripButton.Checked = bold;
            }
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if(bold)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            richTextBox1.SelectionFont = newFont;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                boldToolStripButton.Checked = true;
                boldToolStripMenuItem.Checked = true;
                boldToolStripStatusLabel.Enabled = true;

            }
            else
            {
                boldToolStripButton.Checked = false;
                boldToolStripMenuItem.Checked = false;
                boldToolStripStatusLabel.Enabled = false;
            }

            if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
            {
                underlineToolStripButton.Checked = true;
                underlineToolStripMenuItem.Checked = true;
                underlineToolStripStatusLabel.Enabled = true;

            }
            else
            {
                underlineToolStripButton.Checked = false;
                underlineToolStripMenuItem.Checked = false;
                underlineToolStripStatusLabel.Enabled = false;
            }
            if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
            {
                italicToolStripButton.Checked = true;
                italicToolStripMenuItem.Checked = true;
                italicToolStripStatusLabel.Enabled = true;

            }
            else
            {
                italicToolStripButton.Checked = false;
                italicToolStripMenuItem.Checked = false;
                italicToolStripStatusLabel.Enabled = false;
            }
        }

        private void italicToolStripButton_Click(object sender, EventArgs e)
        {
            bool italic;
            if (sender == italicToolStripButton)
            {
                italic = italicToolStripButton.Checked;
                italicToolStripMenuItem.Checked = italic;
            }
            else
            {
                italic = italicToolStripMenuItem.Checked;
                italicToolStripButton.Checked = italic;
            }
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (italic)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            richTextBox1.SelectionFont = newFont;
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            bool underline;
            if (sender == underlineToolStripButton)
            {
                underline = underlineToolStripButton.Checked;
                underlineToolStripMenuItem.Checked = underline;
            }
            else
            {
                underline = underlineToolStripMenuItem.Checked;
                underlineToolStripButton.Checked = underline;
            }
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (underline)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            richTextBox1.SelectionFont = newFont;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textLengthStripStatusLabel.Text = "Text Length: " + richTextBox1.Text.Length;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Text != "" & filename =="untitled")
            { 
                if(MessageBox.Show("Do you want to save this file?", "Save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    savefile("myFile.rtf");
                }
                        
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            if(about.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Vsaj neki pravilnga!");
            }
            else
            {
                MessageBox.Show("Pa dej bejž!");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                savefile(filename);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = richTextBox1.SelectionFont;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
            richTextBox1.Focus();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = richTextBox1.SelectionColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
            richTextBox1.Focus();
        }
    }
}
