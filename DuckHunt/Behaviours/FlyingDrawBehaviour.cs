using DuckHunt.Factories;
using DuckHunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DuckHunt.Behaviours
{
    class FlyingDrawBehaviour : DrawBehaviour
    {
        private Unit unit;

        public FlyingDrawBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public FlyingDrawBehaviour() { }

        public void Behave(float deltaTime)
        {
            if (unit.dispatcher.CheckAccess())
            {
                unit.rect.Margin = new Thickness(unit.x, unit.y, unit.size, unit.size);
            }
            else
            {
                unit.dispatcher.Invoke(() => unit.rect.Margin = new Thickness(unit.x, unit.y, unit.size, unit.size));
            }

        }

        public static void AddBehaviourToFactory()
        {
            BehaviourFactory.Instance.addDrawBehaviourToMap("flying", new FlyingDrawBehaviour());
        }

        public DrawBehaviour CreateInstance(Unit unit)
        {
            return new FlyingDrawBehaviour(unit);
        }
    }
}
