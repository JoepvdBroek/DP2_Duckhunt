using DuckHunt.Controllers;
using DuckHunt.Factories;
using System.Windows.Media;

namespace DuckHunt.Levels
{
    class Level1 : BaseLevelState , GameLevel
    {
        public Level1()
        {
            id = 1;
            velocity = 1.0F;
            color = Brushes.Yellow;
        }

        public static void AddLevelToFactory()
        {
            LevelFactory.Instance.addLevelToMap(new Level1());
        }

        BaseLevelState GameLevel.CreateInstance()
        {
            return new Level1();
        }

    }
}
