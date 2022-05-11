using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Login child form that allows the user to login to thier created account
 * Basic, unrestricted, username and password creating.
 * Only requires that the username has not been used before
 * Everthing is written and called from a local SQL database, to make this a publically available application the only required change would be the creation of a database server.
 */

namespace Hangman
{
    public partial class LoginForm : Form
    {
        private String username;
        private String pass;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Instansiate() {
            username = username_entry.Text;
            pass = pass_entry.Text;
        }

        private void login_Click(object sender, EventArgs e)
        {
            
        }

        private void login_form_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
