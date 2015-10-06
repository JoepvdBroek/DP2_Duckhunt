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
    class Level4 : BaseLevelState, GameLevel
    {
        public Level4()
        {
            id = 4;
            velocity = 1.6F;
            color = Brushes.Beige;
        }

        public static void AddLevelToFactory()
        {
            LevelFactory.Instance.addLevelToMap(new Level4());
        }

        BaseLevelState GameLevel.CreateInstance()
        {
            return new Level4();
        }
    }
}
