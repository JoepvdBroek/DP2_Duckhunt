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
    class Level5 : BaseLevelState, GameLevel
    {
        public Level5()
        {
            id = 5;
            velocity = 1.8F;
            color = Brushes.Azure;
        }

        public static void AddLevelToFactory()
        {
            LevelFactory.Instance.addLevelToMap(new Level5());
        }

        BaseLevelState GameLevel.CreateInstance()
        {
            return new Level5();
        }

    }
}
