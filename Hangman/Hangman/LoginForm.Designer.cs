
namespace Hangman
{
    partial class LoginForm
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
            this.username_entry = new System.Windows.Forms.TextBox();
            this.pass_entry = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.login_form_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_entry
            // 
            this.username_entry.Location = new System.Drawing.Point(225, 91);
            this.username_entry.Name = "username_entry";
            this.username_entry.Size = new System.Drawing.Size(276, 31);
            this.username_entry.TabIndex = 0;
            // 
            // pass_entry
            // 
            this.pass_entry.Location = new System.Drawing.Point(225, 154);
            this.pass_entry.Name = "pass_entry";
            this.pass_entry.Size = new System.Drawing.Size(276, 31);
            this.pass_entry.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(225, 215);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(136, 44);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // login_form_close
            // 
            this.login_form_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login_form_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login_form_close.Location = new System.Drawing.Point(611, 390);
            this.login_form_close.Name = "login_form_close";
            this.login_form_close.Size = new System.Drawing.Size(103, 44);
            this.login_form_close.TabIndex = 3;
            this.login_form_close.Text = "Close";
            this.login_form_close.UseVisualStyleBackColor = true;
            this.login_form_close.Click += new System.EventHandler(this.login_form_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.login_form_close;
            this.ClientSize = new System.Drawing.Size(740, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_form_close);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass_entry);
            this.Controls.Add(this.username_entry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_entry;
        private System.Windows.Forms.TextBox pass_entry;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button login_form_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}