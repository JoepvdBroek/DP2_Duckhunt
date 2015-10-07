using DuckHunt.Controllers;
using DuckHunt.Factories;
using System.Windows.Media;

namespace DuckHunt.Levels
{
    class Level2 : BaseLevelState, GameLevel
    {
        public Level2()
        {
            id = 2;
            velocity = 1.2F;
            color = Brushes.AliceBlue;

        }

        public static void AddLevelToFactory()
        {
            LevelFactory.Instance.addLevelToMap(new Level2());
        }

        BaseLevelState GameLevel.CreateInstance()
        {
            return new Level2();
        }
    }
}
