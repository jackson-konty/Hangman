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
    public partial class CreateForm : Form
    {
        private String newPass;
        private String newUsername;
        private DateTime birthDate;
        public CreateForm()
        {
            InitializeComponent();
        }
        private void Instansiate(){
            newPass = new_pass.Text;
            newUsername = new_username.Text;
            birthDate = birth_date_entry.Value;
        }

        private void create_form_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Instansiate();
        }
    }
}
