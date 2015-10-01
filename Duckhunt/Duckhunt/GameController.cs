using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duckhunt
{
    internal class GameController
    {
        private FormView formView;
        private UnitFactory unitFactory;
        private BehaviourFactory behaviourFactory;
        private MoveContainer moveContainer;
        private DrawContainer drawContainer;
        private Graphics graphics;
        private Timer timer;
        private bool running;

        public GameController(FormView view, Graphics g)
        {
            unitFactory = UnitFactory.Instance;
            behaviourFactory = BehaviourFactory.Instance;
            moveContainer = new MoveContainer();
            drawContainer = new DrawContainer();
            graphics = g;
            timer = new Timer();

            formView = view;

            Unit firstUnit = new Duck(moveContainer, drawContainer, behaviourFactory, graphics);

            running = true;
            new Thread(new ThreadStart(Run)).Start();
            
        }

        private void Run()
        {
            while (running)
            {
                moveContainer.UpdateUnits();
                drawContainer.UpdateUnits(graphics);
                formView.UpdateView();
                Thread.Sleep(40);
            }
        }

        public void StopLoop()
        {
            running = false;
        }
    
    }
}