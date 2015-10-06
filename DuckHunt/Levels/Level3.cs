using DuckHunt.Controllers;
using DuckHunt.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DuckHunt.Levels
{
    class Level3 : BaseLevelState, GameLevel
    {
        public Level3()
        {
            id = 3;
            velocity = 1.4F;
            color = Brushes.DarkGoldenrod;
        }

        public static void AddLevelToFactory()
        {
            LevelFactory.Instance.addLevelToMap(new Level3());
        }

        BaseLevelState GameLevel.CreateInstance()
        {
            return new Level3();
        }
    }
}
