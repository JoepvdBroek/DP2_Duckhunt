using DuckHunt.Factories;
using System.Windows.Media;
using DuckHunt.Levels;

namespace DuckHunt.Controllers
{
    class BaseLevelState
    {
        private GameController gameController;
        public int id { get; set; }
        public Brush color { get; set; }
        public float velocity { get; set; }

        //constructor for gameController
        public BaseLevelState(GameController gc)
        {
            id = 0;
            gameController = gc;

            Level1.AddLevelToFactory();
            Level2.AddLevelToFactory();
            Level3.AddLevelToFactory();
            Level4.AddLevelToFactory();
            Level5.AddLevelToFactory();

        }

        //constructor for levels
        public BaseLevelState() { }

        public void setGame(GameController gc)
        {
            gameController = gc;
        }

        public void Update() { }

        public void Draw()
        {
            if (gameController.dispatcher.CheckAccess())
            {
                gameController.window.Background = color;
            }
            else
            {
                gameController.dispatcher.Invoke(() => gameController.window.Background = color);
            }
        }

        public void NextLevel()
        {
            BaseLevelState nextLevel = LevelFactory.Instance.NextLevel(this);

            if(nextLevel == null)
            {
                //finished
                gameController.Finish();
            }

            gameController.SetLevel(nextLevel);
        }
    }
}
