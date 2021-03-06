﻿using DuckHunt.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt.Containers
{
    class DrawContainer : Container
    {
        public DrawContainer()
        {
            FlyingDrawBehaviour.AddBehaviourToFactory();
        }

        public void Add(DrawBehaviour _drawBehaviour)
        {
            behaviours.Add(_drawBehaviour);
        }

        public void Remove(DrawBehaviour _drawBehaviour)
        {
            if (behaviours.Contains(_drawBehaviour))
            {
                behaviours.Remove(_drawBehaviour);
            }
        }

        public void DrawUnits(float deltaTime)
        {
            foreach(Behaviour behaviour in behaviours)
            {
                behaviour.Behave(deltaTime);
            }
        }
    }
}
