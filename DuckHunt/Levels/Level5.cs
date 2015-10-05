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
    class Level5 : BaseLevelState
    {
        public Level5()
        {
            id = 5;
            velocity = 1.8F;
            color = Brushes.Azure;
            levelFactory = LevelFactory.Instance;
        }
    
    }
}
