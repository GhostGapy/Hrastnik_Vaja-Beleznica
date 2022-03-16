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
    public partial class MyAboutForm : Form
    {
        public MyAboutForm()
        {
            InitializeComponent();
        }

        private void button_ja_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button_ne_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
