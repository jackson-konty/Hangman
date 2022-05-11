
namespace Hangman
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.open_info = new System.Windows.Forms.Button();
            this.game_start = new System.Windows.Forms.Button();
            this.difficulty_box = new System.Windows.Forms.GroupBox();
            this.difficulty_open = new System.Windows.Forms.RadioButton();
            this.difficulty_hard = new System.Windows.Forms.RadioButton();
            this.difficulty_medium = new System.Windows.Forms.RadioButton();
            this.difficulty_easy = new System.Windows.Forms.RadioButton();
            this.hint_box = new System.Windows.Forms.GroupBox();
            this.hint_context = new System.Windows.Forms.RadioButton();
            this.hint_definition = new System.Windows.Forms.RadioButton();
            this.music_option = new System.Windows.Forms.CheckBox();
            this.close_main = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.difficulty_box.SuspendLayout();
            this.hint_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.open_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 65);
            this.panel1.TabIndex = 0;
            // 
            // open_info
            // 
            this.open_info.BackColor = System.Drawing.Color.Cornsilk;
            this.open_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.open_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_info.Location = new System.Drawing.Point(1318, 0);
            this.open_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.open_info.Name = "open_info";
            this.open_info.Size = new System.Drawing.Size(176, 65);
            this.open_info.TabIndex = 3;
            this.open_info.Text = "Info";
            this.open_info.UseVisualStyleBackColor = false;
            this.open_info.Click += new System.EventHandler(this.open_info_Click);
            // 
            // game_start
            // 
            this.game_start.BackColor = System.Drawing.Color.PaleGreen;
            this.game_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game_start.Location = new System.Drawing.Point(728, 556);
            this.game_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.game_start.Name = "game_start";
            this.game_start.Size = new System.Drawing.Size(180, 63);
            this.game_start.TabIndex = 1;
            this.game_start.Text = "START";
            this.game_start.UseVisualStyleBackColor = false;
            this.game_start.Click += new System.EventHandler(this.game_start_Click);
            // 
            // difficulty_box
            // 
            this.difficulty_box.Controls.Add(this.difficulty_open);
            this.difficulty_box.Controls.Add(this.difficulty_hard);
            this.difficulty_box.Controls.Add(this.difficulty_medium);
            this.difficulty_box.Controls.Add(this.difficulty_easy);
            this.difficulty_box.Location = new System.Drawing.Point(728, 287);
            this.difficulty_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.difficulty_box.Name = "difficulty_box";
            this.difficulty_box.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.difficulty_box.Size = new System.Drawing.Size(188, 156);
            this.difficulty_box.TabIndex = 2;
            this.difficulty_box.TabStop = false;
            this.difficulty_box.Text = "Difficulty";
            // 
            // difficulty_open
            // 
            this.difficulty_open.AutoSize = true;
            this.difficulty_open.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficulty_open.Location = new System.Drawing.Point(4, 115);
            this.difficulty_open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.difficulty_open.Name = "difficulty_open";
            this.difficulty_open.Size = new System.Drawing.Size(180, 29);
            this.difficulty_open.TabIndex = 3;
            this.difficulty_open.Text = "Open";
            this.difficulty_open.UseVisualStyleBackColor = true;
            this.difficulty_open.CheckedChanged += new System.EventHandler(this.difficulty_open_CheckedChanged);
            // 
            // difficulty_hard
            // 
            this.difficulty_hard.AutoSize = true;
            this.difficulty_hard.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficulty_hard.Location = new System.Drawing.Point(4, 86);
            this.difficulty_hard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.difficulty_hard.Name = "difficulty_hard";
            this.difficulty_hard.Size = new System.Drawing.Size(180, 29);
            this.difficulty_hard.TabIndex = 4;
            this.difficulty_hard.Text = "Hard";
            this.difficulty_hard.UseVisualStyleBackColor = true;
            this.difficulty_hard.CheckedChanged += new System.EventHandler(this.difficulty_hard_CheckedChanged);
            // 
            // difficulty_medium
            // 
            this.difficulty_medium.AutoSize = true;
            this.difficulty_medium.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficulty_medium.Location = new System.Drawing.Point(4, 57);
            this.difficulty_medium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.difficulty_medium.Name = "difficulty_medium";
            this.difficulty_medium.Size = new System.Drawing.Size(180, 29);
            this.difficulty_medium.TabIndex = 5;
            this.difficulty_medium.Text = "Medium";
            this.difficulty_medium.UseVisualStyleBackColor = true;
            this.difficulty_medium.CheckedChanged += new System.EventHandler(this.difficulty_medium_CheckedChanged);
            // 
            // difficulty_easy
            // 
            this.difficulty_easy.AutoSize = true;
            this.difficulty_easy.Checked = true;
            this.difficulty_easy.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficulty_easy.Location = new System.Drawing.Point(4, 28);
            this.difficulty_easy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.difficulty_easy.Name = "difficulty_easy";
            this.difficulty_easy.Size = new System.Drawing.Size(180, 29);
            this.difficulty_easy.TabIndex = 6;
            this.difficulty_easy.TabStop = true;
            this.difficulty_easy.Text = "Easy";
            this.difficulty_easy.UseVisualStyleBackColor = true;
            this.difficulty_easy.CheckedChanged += new System.EventHandler(this.difficulty_easy_CheckedChanged);
            // 
            // hint_box
            // 
            this.hint_box.Controls.Add(this.hint_context);
            this.hint_box.Controls.Add(this.hint_definition);
            this.hint_box.Location = new System.Drawing.Point(522, 287);
            this.hint_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hint_box.Name = "hint_box";
            this.hint_box.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hint_box.Size = new System.Drawing.Size(202, 94);
            this.hint_box.TabIndex = 3;
            this.hint_box.TabStop = false;
            this.hint_box.Text = "Hint";
            // 
            // hint_context
            // 
            this.hint_context.AutoSize = true;
            this.hint_context.Dock = System.Windows.Forms.DockStyle.Top;
            this.hint_context.Location = new System.Drawing.Point(4, 57);
            this.hint_context.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hint_context.Name = "hint_context";
            this.hint_context.Size = new System.Drawing.Size(194, 29);
            this.hint_context.TabIndex = 5;
            this.hint_context.Text = "Context";
            this.hint_context.UseVisualStyleBackColor = true;
            this.hint_context.CheckedChanged += new System.EventHandler(this.hint_context_CheckedChanged);
            // 
            // hint_definition
            // 
            this.hint_definition.AutoSize = true;
            this.hint_definition.Checked = true;
            this.hint_definition.Dock = System.Windows.Forms.DockStyle.Top;
            this.hint_definition.Location = new System.Drawing.Point(4, 28);
            this.hint_definition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hint_definition.Name = "hint_definition";
            this.hint_definition.Size = new System.Drawing.Size(194, 29);
            this.hint_definition.TabIndex = 6;
            this.hint_definition.TabStop = true;
            this.hint_definition.Text = "Definition";
            this.hint_definition.UseVisualStyleBackColor = true;
            this.hint_definition.CheckedChanged += new System.EventHandler(this.hint_definition_CheckedChanged);
            // 
            // music_option
            // 
            this.music_option.AutoSize = true;
            this.music_option.Location = new System.Drawing.Point(926, 315);
            this.music_option.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.music_option.Name = "music_option";
            this.music_option.Size = new System.Drawing.Size(101, 29);
            this.music_option.TabIndex = 4;
            this.music_option.Text = "Music";
            this.music_option.UseVisualStyleBackColor = true;
            this.music_option.CheckedChanged += new System.EventHandler(this.music_option_CheckedChanged);
            // 
            // close_main
            // 
            this.close_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_main.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_main.Location = new System.Drawing.Point(1362, 820);
            this.close_main.Name = "close_main";
            this.close_main.Size = new System.Drawing.Size(120, 53);
            this.close_main.TabIndex = 5;
            this.close_main.Text = "close";
            this.close_main.UseVisualStyleBackColor = true;
            this.close_main.Click += new System.EventHandler(this.close_main_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.game_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.close_main;
            this.ClientSize = new System.Drawing.Size(1494, 885);
            this.Controls.Add(this.close_main);
            this.Controls.Add(this.music_option);
            this.Controls.Add(this.hint_box);
            this.Controls.Add(this.difficulty_box);
            this.Controls.Add(this.game_start);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1126, 742);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.difficulty_box.ResumeLayout(false);
            this.difficulty_box.PerformLayout();
            this.hint_box.ResumeLayout(false);
            this.hint_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button game_start;
        private System.Windows.Forms.GroupBox difficulty_box;
        private System.Windows.Forms.RadioButton difficulty_open;
        private System.Windows.Forms.RadioButton difficulty_hard;
        private System.Windows.Forms.RadioButton difficulty_medium;
        private System.Windows.Forms.RadioButton difficulty_easy;
        private System.Windows.Forms.GroupBox hint_box;
        private System.Windows.Forms.RadioButton hint_context;
        private System.Windows.Forms.RadioButton hint_definition;
        private System.Windows.Forms.Button open_info;
        private System.Windows.Forms.CheckBox music_option;
        private System.Windows.Forms.Button close_main;
    }
}

