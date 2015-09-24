using System;
using System.Collections.Generic;
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
        private Thread thread;

        private bool running;

        public GameController()
        {
            unitFactory = UnitFactory.Instance;
            behaviourFactory = BehaviourFactory.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formView = new FormView();
            Application.Run(formView);

            running = true;
            thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private void Run()
        {
            while (running)
            {
                formView.UpdateView();
                Thread.Sleep(50);
            }
        }
    
    }
}