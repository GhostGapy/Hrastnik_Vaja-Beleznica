using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beležnica1
{
    public partial class Form1 : Form
    {
        string filename = "untilted";

        public Form1()
        {
            InitializeComponent();
        }


        void changeFilename(string newFilename)
        {
            filename = newFilename;
            this.Text = "Beležnica - " + filename;
        }

        private void NewToolsStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            changeFilename("untilted");
        }

        private void SaveToolsStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile("myFile.rtf");
                changeFilename("myFile.rtf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenToolsStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("myFile.rtf");
                changeFilename("myFile.rtf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoldToolsStripButton_Click(object sender, EventArgs e)
        {
            bool bold;
            if(sender == BoldToolsStripButton)
            {
                bold = BoldToolsStripButton.Checked;
                boldToolStripMenuItem.Checked = bold;
            }
            else
            {
                bold = boldToolStripMenuItem.Checked;
                BoldToolsStripButton.Checked = bold;
            }

            //font izbrange besedila
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if(bold) //samo ce je bool, ce ni bool daj (bold == true)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold); // ALI
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold); // AND NEGACIJA
            }

            // dam nov font izbranemu besedilu
            richTextBox1.SelectionFont = newFont;

            richTextBox1.Focus();
        }

        private void ItalicToolsStripButton_Click(object sender, EventArgs e)
        {
            bool italic;
            if (sender == ItalicToolsStripButton)
            {
                italic = ItalicToolsStripButton.Checked;
                italicToolStripMenuItem.Checked = italic;
            }
            else
            {
                italic = italicToolStripMenuItem.Checked;
                ItalicToolsStripButton.Checked = italic;
            }

            //font izbrange besedila
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (italic) //samo ce je bool, ce ni bool daj (bold == true)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic); // ALI
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic); // AND NEGACIJA
            }

            // dam nov font izbranemu besedilu
            richTextBox1.SelectionFont = newFont;

            richTextBox1.Focus();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                BoldToolsStripButton.Checked = true;
                boldToolStripMenuItem.Checked = true;
                BoldStatusStripLabel.Enabled = true;
            }
            else
            {
                BoldToolsStripButton.Checked = false;
                boldToolStripMenuItem.Checked = false;
                BoldStatusStripLabel.Enabled = false;
            }

            if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
            {
                ItalicToolsStripButton.Checked = true;
                italicToolStripMenuItem.Checked = true;
                ItalicStatusStripLabel.Enabled = true;
            }
            else
            {
                ItalicToolsStripButton.Checked = false;
                italicToolStripMenuItem.Checked = false;
                ItalicStatusStripLabel.Enabled = false;
            }

            if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
            {
                UnderToolsStripButton.Checked = true;
                underlineToolStripMenuItem.Checked = true;
                UnderlineStatusStripLabel.Enabled = true;
            }
            else
            {
                UnderToolsStripButton.Checked = false;
                underlineToolStripMenuItem.Checked = false;
                UnderlineStatusStripLabel.Enabled = false;
            }
        }

        private void UnderToolsStripButton_Click(object sender, EventArgs e)
        {
            bool Under;
            if (sender == UnderToolsStripButton)
            {
                Under = UnderToolsStripButton.Checked;
                underlineToolStripMenuItem.Checked = Under;
            }
            else
            {
                Under = underlineToolStripMenuItem.Checked;
                UnderToolsStripButton.Checked = Under;
            }

            //font izbrange besedila
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (Under) //samo ce je bool, ce ni bool daj (bold == true)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline); // ALI
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline); // AND NEGACIJA
            }

            // dam nov font izbranemu besedilu
            richTextBox1.SelectionFont = newFont;

            richTextBox1.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            TextLengthStatusStripLabel.Text = "Text Lenght: " + richTextBox1.Text.Length;
        }
    }
}
