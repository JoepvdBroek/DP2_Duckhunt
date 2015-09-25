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

        private bool running;

        public GameController(FormView view)
        {
            unitFactory = UnitFactory.Instance;
            behaviourFactory = BehaviourFactory.Instance;
            moveContainer = new MoveContainer();
            drawContainer = new DrawContainer();

            formView = view;

            Unit firstUnit = new Duck(moveContainer, drawContainer, behaviourFactory);

            running = true;
            new Thread(new ThreadStart(Run)).Start();
            
        }

        private void Run()
        {
            while (running)
            {
                moveContainer.UpdateUnits();
                drawContainer.UpdateUnits(formView.Graphics);
                formView.UpdateView();
                Thread.Sleep(1000);
            }
        }
    
    }
}