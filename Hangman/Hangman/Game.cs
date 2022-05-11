
namespace Hangman
{
    public enum Difficulty { 
        easy,
        medium,
        hard,
        open}
    public enum Hint { 
        definition,
        context
    }
    public class Game
    {
        public Difficulty difficulty { get; }
        public bool hangman { get; }
        public Hint hintType { get; }
        public bool adult { get; }
        public int streak { get; set; }
        public Game(Hint hint,Difficulty difficulty,bool hangman) {
            this.hintType = hint;
            this.difficulty = difficulty;
            this.hangman = hangman;
            this.streak = 0;
        }
        public void ResetStreak() {
            streak = 0;
        }
        public void AddStreak() {
            streak += 1;
        }
    }
}
