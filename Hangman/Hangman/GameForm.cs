using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Hangman
{
    public partial class GameForm : Form
    {
        private Game currentGame;
        private GameWord gameWord;
        private Hashtable guessed;
        private Hashtable wordSet = new Hashtable();
        private int incorrectCount;

        public GameForm(Game game)
        {
            this.currentGame = game;
            CreateWordSet();
            RetrieveGameWord();
            InitializeComponent();
            Init();
        }
        //Update methods for visual elements
        //Intilizes all visual elements and gets a new word
        public void Init()
        {
            incorrectCount = 0;
            streak_display.Text = currentGame.streak.ToString();
            word_guess.Text = "";
            guess_left.Text = "Guesses Remaining: 6";
            guessed = new Hashtable();
            RetrieveGameWord();
            DisplayHint();
            SetLetterButtonsVisible();
            SetGraveInvisible();
            UpdateBlanks();
        }
        //Displays the hint from the word
        private void DisplayHint()
        {
            switch (currentGame.hintType)
            {
                case Hint.definition:
                    clue_display.Text = gameWord.definition;
                    break;
                case Hint.context:
                    clue_display.Text = " "+gameWord.GetBlankContext(guessed);
                    break;
            }
        }
        //Sets graveyard elements to invisible. This was done so that I could design elements while visible and still have them not show
        private void SetGraveInvisible()
        {
            a_label.Visible = false;
            b_label.Visible = false;
            c_label.Visible = false;
            d_label.Visible = false;
            e_label.Visible = false;
            f_label.Visible = false;
            g_label.Visible = false;
            h_label.Visible = false;
            i_label.Visible = false;
            j_label.Visible = false;
            k_label.Visible = false;
            l_label.Visible = false;
            m_label.Visible = false;
            n_label.Visible = false;
            o_label.Visible = false;
            p_label.Visible = false;
            q_label.Visible = false;
            r_label.Visible = false;
            s_label.Visible = false;
            t_label.Visible = false;
            u_label.Visible = false;
            v_label.Visible = false;
            w_label.Visible = false;
            x_label.Visible = false;
            y_label.Visible = false;
            z_label.Visible = false;
        }
        //Sets all letter buttons to visible, this is used when resarting the game
        private void SetLetterButtonsVisible()
        {
            a_letter.Visible = true;
            b_letter.Visible = true;
            c_letter.Visible = true;
            d_letter.Visible = true;
            e_letter.Visible = true;
            f_letter.Visible = true;
            g_letter.Visible = true;
            h_letter.Visible = true;
            i_letter.Visible = true;
            j_letter.Visible = true;
            k_letter.Visible = true;
            l_letter.Visible = true;
            m_letter.Visible = true;
            n_letter.Visible = true;
            o_letter.Visible = true;
            p_letter.Visible = true;
            q_letter.Visible = true;
            r_letter.Visible = true;
            s_letter.Visible = true;
            t_letter.Visible = true;
            u_letter.Visible = true;
            v_letter.Visible = true;
            w_letter.Visible = true;
            x_letter.Visible = true;
            y_letter.Visible = true;
            z_letter.Visible = true;
        }
        //Updates the graveyard when an incorrect letter is guessed
        private void UpdateGrave(string letter)
        {
            switch (letter)
            {
                case "A":
                    a_label.Visible = true;
                    break;
                case "B":
                    b_label.Visible = true;
                    break;
                case "C":
                    c_label.Visible = true;
                    break;
                case "D":
                    d_label.Visible = true;
                    break;
                case "E":
                    e_label.Visible = true;
                    break;
                case "F":
                    f_label.Visible = true;
                    break;
                case "G":
                    g_label.Visible = true;
                    break;
                case "H":
                    h_label.Visible = true;
                    break;
                case "I":
                    i_label.Visible = true;
                    break;
                case "J":
                    j_label.Visible = true;
                    break;
                case "K":
                    k_label.Visible = true;
                    break;
                case "L":
                    l_label.Visible = true;
                    break;
                case "M":
                    m_label.Visible = true;
                    break;
                case "N":
                    n_label.Visible = true;
                    break;
                case "O":
                    o_label.Visible = true;
                    break;
                case "P":
                    p_label.Visible = true;
                    break;
                case "Q":
                    q_label.Visible = true;
                    break;
                case "R":
                    r_label.Visible = true;
                    break;
                case "S":
                    s_label.Visible = true;
                    break;
                case "T":
                    t_label.Visible = true;
                    break;
                case "U":
                    u_label.Visible = true;
                    break;
                case "V":
                    v_label.Visible = true;
                    break;
                case "W":
                    w_label.Visible = true;
                    break;
                case "X":
                    x_label.Visible = true;
                    break;
                case "Y":
                    y_label.Visible = true;
                    break;
                case "Z":
                    z_label.Visible = true;
                    break;
            }
        }
        //Updates the blanks based on the letters that have been guessed
        private void UpdateBlanks()
        {
            string blanks = gameWord.GetBlanks(guessed);
            blank_display.Text = blanks;
        }

        //Data methods

        private bool AddGuessed(string letter)
        {
            if (gameWord.GetWordLower().Contains(letter.ToLower()))
            {
                for (int i = 0; i < gameWord.GetWordLower().Length; i++)
                {
                    if (gameWord.GetWordLower().Substring(i, 1).Equals(letter.ToLower()))
                    {
                        guessed.Add(i, letter.ToLower());
                    }
                }
                return true;
            }
            else { return false; }

        }

        //Adds to the incorrect number and updates the visual element
        private void IncrementIncorrect() {
            incorrectCount++;
            switch (incorrectCount)
            {
                case 1:
                    hangman_hanger.BackgroundImage = Properties.Resources.hangman1;
                    break;
                case 2:
                    hangman_hanger.BackgroundImage = Properties.Resources.hangman2;
                    break;
                case 3:
                    hangman_hanger.BackgroundImage = Properties.Resources.hangman3;
                    break;
                case 4:
                    hangman_hanger.BackgroundImage = Properties.Resources.hangman4;
                    break;
                case 5:
                    hangman_hanger.BackgroundImage = Properties.Resources.hangman5;
                    break;
                default:
                    hangman_hanger.BackgroundImage = Properties.Resources.hangman0;
                    break;
            }
            if (incorrectCount == 6) {
                MessageBox.Show("GAME OVER");
                Close();
            }
            guess_left.Text = "Guesses Remaining: " + (6- incorrectCount);


        }

        //Retreives the word for the game from the file
        //TODO --Implement database/JSON/CSV file acces to access words
        private void RetrieveGameWord()
        {
            Random random = new Random();
            int rand = random.Next(wordSet.Keys.Count - 1);
            string[] values =  (string[]) wordSet[rand];
            gameWord = new GameWord(values[0],values[1],values[2]);

        }
        private void CreateWordSet() {
            String modifier;
            switch (currentGame.difficulty) {
                case Difficulty.easy:
                    modifier = "Easy";
                    break;
                case Difficulty.medium:
                    modifier = "Medium";
                    break;
                case Difficulty.hard:
                    modifier = "Hard";
                    break;
                default:
                    modifier = "";
                    break;
            }
            string fileName = string.Format("words{0}.csv", modifier);
            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    wordSet.Add(int.Parse(fields[0]), new string[] { fields[1], fields[2],fields[3]}); ;
                    Debug.WriteLine(fields[1]);
                }
            }

        }

        //Event Handlers
        private void letterButtonClick(object sender, EventArgs e)
        {
            Button letterButton = (Button)sender;
            letterButton.Visible = false;
            string letter = letterButton.Text;
            UpdateGrave(letter);
            if (AddGuessed(letter)){
                if (currentGame.hintType == Hint.context) { DisplayHint(); }
                UpdateBlanks();
            }
            else{
                IncrementIncorrect();
            }
        }
        private void close_Click(object sender, EventArgs e) { Close(); }

        private void skip_Click(object sender, EventArgs e)
        {
            currentGame.ResetStreak();
            Init();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (guessed.Keys.Count == gameWord.Size()||gameWord.StringEquals(word_guess.Text)) {
                   currentGame.AddStreak();
                   Init();
            }
            else if(word_guess.Text != "") { IncrementIncorrect(); word_guess.Text = ""; }
        }

        private void word_guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                //Allows the user to use the back key
                bool isBack = e.KeyChar.Equals('\b');

                if (!isBack)
                {
                    //Any other keystrokes are ignored
                    e.Handled = true;
                }
            }
        }

        private void letter_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
