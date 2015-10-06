﻿using DuckHunt.Behaviours;
using DuckHunt.Containers;
using DuckHunt.Factories;
using DuckHunt.Models;
using System;
using System.Windows.Media;
using System.Windows.Threading;

namespace DuckHunt
{
    class Duck : Unit
    {
        public Duck(MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window) : base(mc, dc, bf, window)
        {
            //rnd = new Random();
            size = 40;
            x = 0;
            y = rnd.Next(26, 300);
            color = Brushes.PowderBlue;
            velocity = 1.0F;

            InitUnit();
        }

        
    }
}