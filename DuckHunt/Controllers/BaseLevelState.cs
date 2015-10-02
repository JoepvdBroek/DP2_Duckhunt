﻿using DuckHunt.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DuckHunt.Controllers
{
    class BaseLevelState
    {
        private GameController gameController;
        protected LevelFactory levelFactory;
        public int id { get; set; }
        public Brush color { get; set; }
        public MainWindow window { get; set; }

        //constructor for gameController
        public BaseLevelState(GameController gc)
        {
            id = 0;
            gameController = gc;
            levelFactory = LevelFactory.Instance;
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
            window.Background = color;
        }

        public void NextLevel()
        {
            BaseLevelState nextLevel = levelFactory.NextLevel(this);

            if(nextLevel == null)
            {
                //finished
                gameController.Finish();
            }

            gameController.SetLevel(nextLevel);
        }
    }
}
