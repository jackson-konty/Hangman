
namespace Hangman
{
    partial class InfoForm
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
            this.info_text = new System.Windows.Forms.TextBox();
            this.close_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info_text
            // 
            this.info_text.Location = new System.Drawing.Point(26, 25);
            this.info_text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.info_text.Multiline = true;
            this.info_text.Name = "info_text";
            this.info_text.ReadOnly = true;
            this.info_text.Size = new System.Drawing.Size(1190, 391);
            this.info_text.TabIndex = 0;
            // 
            // close_info
            // 
            this.close_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_info.Location = new System.Drawing.Point(1082, 451);
            this.close_info.Name = "close_info";
            this.close_info.Size = new System.Drawing.Size(122, 51);
            this.close_info.TabIndex = 1;
            this.close_info.Text = "Close";
            this.close_info.UseVisualStyleBackColor = true;
            this.close_info.Click += new System.EventHandler(this.close_info_Click);
            // 
            // InfoForm
            // 
            this.AcceptButton = this.close_info;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_info;
            this.ClientSize = new System.Drawing.Size(1238, 514);
            this.Controls.Add(this.close_info);
            this.Controls.Add(this.info_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1264, 585);
            this.Name = "InfoForm";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox info_text;
        private System.Windows.Forms.Button close_info;
    }
}