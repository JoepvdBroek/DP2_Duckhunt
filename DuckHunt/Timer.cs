﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt
{
    class Timer
    { 
        [DllImport("kernel32.dll")]
        private static extern long GetTickCount();

        private long StartTick = 0;

        public Timer()
        {
            Reset();
        }

        public void Reset()
        {
            StartTick = GetTickCount();
        }

        public long GetTicks()
        {
            long currentTick = 0;
            currentTick = GetTickCount();

            return currentTick - StartTick;
        }
    }
}
