
using System;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainForm : Form
    {
        Difficulty difficulty;
        Hint hint;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MainForm()
        {
            InitializeComponent();
            Instatiate();
        }
        private void Instatiate() 
        {
            difficulty = Difficulty.easy;
            hint = Hint.definition;

        }
        private void PlayMusic() {
            player.SoundLocation = "backround.wav";
            player.LoadAsync();
            player.PlayLooping();
        }
        private void StopMusic() {
            player.Stop();
        }

        private void login_form_open_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void create_form_open_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }

        private void game_start_Click(object sender, EventArgs e)
        {
            Game game = new Game(hint, difficulty,true);
            GameForm gameForm = new GameForm(game);
            gameForm.ShowDialog();

        }

        private void difficulty_easy_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.easy;
        }

        private void difficulty_medium_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.medium;
        }

        private void difficulty_hard_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.hard;
        }

        private void difficulty_open_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.open;
        }

        private void hint_definition_CheckedChanged(object sender, EventArgs e)
        {
            hint = Hint.definition;
        }

        private void hint_context_CheckedChanged(object sender, EventArgs e)
        {
            hint = Hint.context;
        }

        private void open_info_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void music_option_CheckedChanged(object sender, EventArgs e)
        {
            if (music_option.Checked) { PlayMusic(); }
            else { StopMusic(); }
        }

        private void close_main_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
