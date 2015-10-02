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
    class Level1 : BaseLevelState
    {
        public Level1()
        {
            id = 1;
            color = Brushes.Yellow;
            levelFactory = LevelFactory.Instance;
        }
    }
}
