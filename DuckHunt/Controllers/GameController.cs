using DuckHunt.Containers;
using DuckHunt.Controllers;
using DuckHunt.Factories;
using DuckHunt.Models;
using System;
using System.Collections;
using System.Threading;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace DuckHunt
{
    class GameController
    {
        private UnitFactory unitFactory;
        private BehaviourFactory behaviourFactory;
        private MoveContainer moveContainer;
        private DrawContainer drawContainer;
        public MainWindow window;
        private bool running = true;
        private Timer timer;
        private BaseLevelState currentLevel;
        public Dispatcher dispatcher;
        private ArrayList units;
        public static int score = 0;
        private Thread t2;

        public GameController(MainWindow window)
        {
            unitFactory = UnitFactory.Instance;
            behaviourFactory = BehaviourFactory.Instance;
            moveContainer = new MoveContainer();
            drawContainer = new DrawContainer();
            units = new ArrayList();
            
            this.window = window;

            timer = new Timer();

            dispatcher = Dispatcher.CurrentDispatcher;

            currentLevel = new BaseLevelState(this); //maak level 1 aan
            currentLevel.NextLevel();

            Crow.AddUnitToFactory();
            Duck.AddUnitToFactory();

            Unit unit1 = unitFactory.CreateUnit("Duck", moveContainer, drawContainer, behaviourFactory, window);
            units.Add(unit1);
            //Thread t = new Thread(new ThreadStart(gameLoop));
            //t.Start();

            Unit unit2 = unitFactory.CreateUnit("Crow", moveContainer, drawContainer, behaviourFactory, window);
            units.Add(unit2);

            t2 = new Thread(new ThreadStart(gameLoop));
            t2.Start();
        }

        public void SetLevel(BaseLevelState nextLevel)
        {
            if(nextLevel != null)
            {
                currentLevel = nextLevel;
                currentLevel.setGame(this);
                currentLevel.Draw();
                window.setLevelLabel(currentLevel.id.ToString());

                foreach (Unit unit in units)
                {
                    unit.velocity = nextLevel.velocity;
                }
            }
            else //Finished last level
            {
                Finish();
            }
        }

        public void UpdateScore(int i)
        {
            window.setScoreLabel(i.ToString());
        }

        public void NextLevel()
        {
            currentLevel.NextLevel();
        }

        public void Finish()
        {
            running = false;
            window.setFinishedScore(score.ToString());
            window.ShowFinishedLabel();
            t2.Abort();
        }

        public void StopGame()
        {
            running = false;
            Environment.Exit(0);
        }

        public void gameLoop()
        {
            int counter = 0;

            float deltaTime = 1;
            float fps;

            while (running)
            {
                if (counter > 1000)
                {
                    counter = 0;
                    NextLevel();
                }
                counter++;

                timer.Reset();

                moveContainer.MoveUnits(deltaTime);
                Thread.Sleep(8);
                drawContainer.DrawUnits(deltaTime);
                UpdateScore(score);

                deltaTime = timer.GetTicks();
                
                if(deltaTime > 0)
                    fps = 1000 / deltaTime;
            }

        }


    }
}
