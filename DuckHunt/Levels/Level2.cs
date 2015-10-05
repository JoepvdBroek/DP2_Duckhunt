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
    class Level2 : BaseLevelState
    {
        public Level2()
        {
            id = 2;
            velocity = 1.2F;
            color = Brushes.AliceBlue;
            levelFactory = LevelFactory.Instance;

        }
    }
}
