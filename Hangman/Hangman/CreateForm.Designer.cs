
namespace Hangman
{
    partial class CreateForm
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
            this.birth_date_entry = new System.Windows.Forms.DateTimePicker();
            this.new_username = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_form_close = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birth_date_entry
            // 
            this.birth_date_entry.Location = new System.Drawing.Point(196, 233);
            this.birth_date_entry.MaxDate = new System.DateTime(2021, 11, 24, 0, 0, 0, 0);
            this.birth_date_entry.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.birth_date_entry.Name = "birth_date_entry";
            this.birth_date_entry.Size = new System.Drawing.Size(367, 31);
            this.birth_date_entry.TabIndex = 0;
            this.birth_date_entry.Value = new System.DateTime(2021, 11, 24, 0, 0, 0, 0);
            // 
            // new_username
            // 
            this.new_username.Location = new System.Drawing.Point(196, 123);
            this.new_username.Name = "new_username";
            this.new_username.Size = new System.Drawing.Size(231, 31);
            this.new_username.TabIndex = 1;
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(196, 161);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(231, 31);
            this.new_pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthdate";
            // 
            // create_form_close
            // 
            this.create_form_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create_form_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.create_form_close.Location = new System.Drawing.Point(712, 462);
            this.create_form_close.Name = "create_form_close";
            this.create_form_close.Size = new System.Drawing.Size(105, 41);
            this.create_form_close.TabIndex = 6;
            this.create_form_close.Text = "Close";
            this.create_form_close.UseVisualStyleBackColor = true;
            this.create_form_close.Click += new System.EventHandler(this.create_form_close_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(196, 310);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(139, 55);
            this.register.TabIndex = 7;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // CreateForm
            // 
            this.AcceptButton = this.register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.create_form_close;
            this.ClientSize = new System.Drawing.Size(829, 515);
            this.Controls.Add(this.register);
            this.Controls.Add(this.create_form_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.new_username);
            this.Controls.Add(this.birth_date_entry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birth_date_entry;
        private System.Windows.Forms.TextBox new_username;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_form_close;
        private System.Windows.Forms.Button register;
    }
}