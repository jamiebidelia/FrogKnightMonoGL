using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrogKnightMonoGL
{
    class Character
    {
        Position myPosition;
        MovementState myMovement;

        int Lives { get; set; }
        int Health { get; set; }

        const int healthMax = 10;
         


        public Character(Position newPosition)
        {
            Lives = 5;
            Health = 5;
            myPosition = new Position();
            myMovement = new MovementState();

        }

        public Character()
        {
            Lives = 5;
            Health = 5;
            myPosition = new Position();
            myMovement = new MovementState();
        }

        public void moveLeft()
        {
            myPosition.X--;
        }

        public void moveRight()
        {
            myPosition.X++;
        }


    }
}
