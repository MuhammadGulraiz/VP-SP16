namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }

        public static int PreviousScore { get; set; }

        public static int HighScore { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 32;
            Height = 32;
            Speed = 6;
            Score = 0;
            Points = 10;
            PreviousScore=0;
            HighScore =500;
            GameOver = false;
            direction = Direction.Right;
        }
    }
}
