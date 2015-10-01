using DuckHunt.Models;
using System.Windows;

namespace DuckHunt.Behaviours
{
    class DrawBehaviour : Behaviour
    {
        private Unit unit;

        public DrawBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public void Behave()
        {
            if (unit.dispatcher.CheckAccess())
            {
                unit.rect.Margin = new Thickness(unit.x, unit.y, unit.size, unit.size);
            }
            else
            {
                unit.dispatcher.Invoke(() => unit.rect.Margin = new Thickness(unit.x, unit.y, unit.size, unit.size));
            }
            //Thread.Sleep(4);

        }
    }
}
