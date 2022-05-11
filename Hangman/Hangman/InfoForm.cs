using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            GetText();
        }
        public void GetText() {
            string text = System.IO.File.ReadAllText("info.txt");
            info_text.Text = text;

        }

        private void close_info_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
