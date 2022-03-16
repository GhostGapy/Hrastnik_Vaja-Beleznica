namespace Beležnica1
{
    partial class MyAboutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ja = new System.Windows.Forms.Button();
            this.button_ne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tole je moj app ce ti ni usec bottih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No a ti je vsec?";
            // 
            // button_ja
            // 
            this.button_ja.Location = new System.Drawing.Point(72, 125);
            this.button_ja.Name = "button_ja";
            this.button_ja.Size = new System.Drawing.Size(75, 23);
            this.button_ja.TabIndex = 2;
            this.button_ja.Text = "Ja";
            this.button_ja.UseVisualStyleBackColor = true;
            this.button_ja.Click += new System.EventHandler(this.button_ja_Click);
            // 
            // button_ne
            // 
            this.button_ne.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_ne.Location = new System.Drawing.Point(174, 125);
            this.button_ne.Name = "button_ne";
            this.button_ne.Size = new System.Drawing.Size(75, 23);
            this.button_ne.TabIndex = 3;
            this.button_ne.Text = "Ne";
            this.button_ne.UseVisualStyleBackColor = true;
            this.button_ne.Click += new System.EventHandler(this.button_ne_Click);
            // 
            // MyAboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 228);
            this.Controls.Add(this.button_ne);
            this.Controls.Add(this.button_ja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyAboutForm";
            this.Text = "MyAboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ja;
        private System.Windows.Forms.Button button_ne;
    }
}