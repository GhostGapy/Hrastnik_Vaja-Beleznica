namespace Beležnica1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreveiwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnderToolsStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UnderlineStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ItalicStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BoldStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextLengthStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.printToolStripMenuItem,
            this.printPreveiwToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.NewFile_16x;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolsStripButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Open_grey_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolsStripButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Save_grey_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolsStripButton_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.SaveAs_16x;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Print_16x_32;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreveiwToolStripMenuItem
            // 
            this.printPreveiwToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.PrintPreview_16x;
            this.printPreveiwToolStripMenuItem.Name = "printPreveiwToolStripMenuItem";
            this.printPreveiwToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printPreveiwToolStripMenuItem.Text = "Print Preveiw";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.toolStripMenuItem4,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.CheckOnClick = true;
            this.boldToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Bold_16x;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.boldToolStripMenuItem.Text = "&Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolsStripButton_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.CheckOnClick = true;
            this.italicToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Italic_16x;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.italicToolStripMenuItem.Text = "&Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolsStripButton_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.CheckOnClick = true;
            this.underlineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Underline_16x;
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.underlineToolStripMenuItem.Text = "&Underline";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.Font_16x;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = global::Beležnica1.Properties.Resources.FontColor_16x;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolsStripButton,
            this.OpenToolsStripButton,
            this.SaveToolsStripButton,
            this.PrintToolsStripButton,
            this.toolStripSeparator1,
            this.BoldToolsStripButton,
            this.ItalicToolsStripButton,
            this.UnderToolsStripButton,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolsStripButton
            // 
            this.NewToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolsStripButton.Image = global::Beležnica1.Properties.Resources.NewFile_16x;
            this.NewToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolsStripButton.Name = "NewToolsStripButton";
            this.NewToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolsStripButton.Text = "toolStripButton1";
            this.NewToolsStripButton.Click += new System.EventHandler(this.NewToolsStripButton_Click);
            // 
            // OpenToolsStripButton
            // 
            this.OpenToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolsStripButton.Image = global::Beležnica1.Properties.Resources.Open_grey_16x;
            this.OpenToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolsStripButton.Name = "OpenToolsStripButton";
            this.OpenToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolsStripButton.Text = "toolStripButton1";
            this.OpenToolsStripButton.Click += new System.EventHandler(this.OpenToolsStripButton_Click);
            // 
            // SaveToolsStripButton
            // 
            this.SaveToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolsStripButton.Image = global::Beležnica1.Properties.Resources.Save_grey_16x;
            this.SaveToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolsStripButton.Name = "SaveToolsStripButton";
            this.SaveToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolsStripButton.Text = "toolStripButton1";
            this.SaveToolsStripButton.Click += new System.EventHandler(this.SaveToolsStripButton_Click);
            // 
            // PrintToolsStripButton
            // 
            this.PrintToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolsStripButton.Image = global::Beležnica1.Properties.Resources.Print_16x_32;
            this.PrintToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolsStripButton.Name = "PrintToolsStripButton";
            this.PrintToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrintToolsStripButton.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldToolsStripButton
            // 
            this.BoldToolsStripButton.CheckOnClick = true;
            this.BoldToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldToolsStripButton.Image = global::Beležnica1.Properties.Resources.Bold_16x;
            this.BoldToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolsStripButton.Name = "BoldToolsStripButton";
            this.BoldToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.BoldToolsStripButton.Text = "toolStripButton1";
            this.BoldToolsStripButton.Click += new System.EventHandler(this.BoldToolsStripButton_Click);
            // 
            // ItalicToolsStripButton
            // 
            this.ItalicToolsStripButton.CheckOnClick = true;
            this.ItalicToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicToolsStripButton.Image = global::Beležnica1.Properties.Resources.Italic_16x;
            this.ItalicToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicToolsStripButton.Name = "ItalicToolsStripButton";
            this.ItalicToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.ItalicToolsStripButton.Text = "toolStripButton1";
            this.ItalicToolsStripButton.Click += new System.EventHandler(this.ItalicToolsStripButton_Click);
            // 
            // UnderToolsStripButton
            // 
            this.UnderToolsStripButton.CheckOnClick = true;
            this.UnderToolsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderToolsStripButton.Image = global::Beležnica1.Properties.Resources.Underline_16x;
            this.UnderToolsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderToolsStripButton.Name = "UnderToolsStripButton";
            this.UnderToolsStripButton.Size = new System.Drawing.Size(23, 22);
            this.UnderToolsStripButton.Text = "toolStripButton1";
            this.UnderToolsStripButton.Click += new System.EventHandler(this.UnderToolsStripButton_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(616, 280);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextLengthStatusStripLabel,
            this.BoldStatusStripLabel,
            this.ItalicStatusStripLabel,
            this.UnderlineStatusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UnderlineStatusStripLabel
            // 
            this.UnderlineStatusStripLabel.Enabled = false;
            this.UnderlineStatusStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderlineStatusStripLabel.Name = "UnderlineStatusStripLabel";
            this.UnderlineStatusStripLabel.Size = new System.Drawing.Size(58, 17);
            this.UnderlineStatusStripLabel.Text = "Underline";
            // 
            // ItalicStatusStripLabel
            // 
            this.ItalicStatusStripLabel.Enabled = false;
            this.ItalicStatusStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalicStatusStripLabel.Name = "ItalicStatusStripLabel";
            this.ItalicStatusStripLabel.Size = new System.Drawing.Size(32, 17);
            this.ItalicStatusStripLabel.Text = "Italic";
            // 
            // BoldStatusStripLabel
            // 
            this.BoldStatusStripLabel.Enabled = false;
            this.BoldStatusStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldStatusStripLabel.Name = "BoldStatusStripLabel";
            this.BoldStatusStripLabel.Size = new System.Drawing.Size(32, 17);
            this.BoldStatusStripLabel.Text = "Bold";
            // 
            // TextLengthStatusStripLabel
            // 
            this.TextLengthStatusStripLabel.AutoSize = false;
            this.TextLengthStatusStripLabel.Name = "TextLengthStatusStripLabel";
            this.TextLengthStatusStripLabel.Size = new System.Drawing.Size(150, 17);
            this.TextLengthStatusStripLabel.Text = "Text Lenght: 0";
            this.TextLengthStatusStripLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 351);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Beležnica - untilted";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreveiwToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolsStripButton;
        private System.Windows.Forms.ToolStripButton OpenToolsStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolsStripButton;
        private System.Windows.Forms.ToolStripButton PrintToolsStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BoldToolsStripButton;
        private System.Windows.Forms.ToolStripButton ItalicToolsStripButton;
        private System.Windows.Forms.ToolStripButton UnderToolsStripButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TextLengthStatusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel BoldStatusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel ItalicStatusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel UnderlineStatusStripLabel;
    }
}

