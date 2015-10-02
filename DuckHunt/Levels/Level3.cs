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
    class Level3 : BaseLevelState
    {
        public Level3()
        {
            id = 3;
            color = Brushes.DarkGoldenrod;
            levelFactory = LevelFactory.Instance;
        }
    }
}
