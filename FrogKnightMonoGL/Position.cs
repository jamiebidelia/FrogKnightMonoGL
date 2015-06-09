﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrogKnightMonoGL
{
    class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public Position()
        {

        }

        public void updatePosition(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }
    }
}
