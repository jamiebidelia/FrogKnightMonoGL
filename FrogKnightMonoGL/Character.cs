using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrogKnightMonoGL
{
    class Character
    {
        public Position myPosition;

        int Lives { get; set; }
        int Health { get; set; }

        const int healthMax = 10;
         


        public Character(Position newPosition)
        {
            Lives = 5;
            Health = 5;
            myPosition = newPosition;

        }

        public Character()
        {
            Lives = 5;
            Health = 5;
            myPosition = new Position();
            //myMovement = new MovementState();
        }

        public void move(Controller controller)
        {
            if (controller.LeftPressed)
                moveLeft();

            if (controller.RightPressed)
                moveRight();

            if (controller.JumpingUp)
                moveUp();

            if (controller.CrouchPressed)
                moveDown();

        }

        public void moveLeft()
        {
            myPosition.X--;
        }

        public void moveRight()
        {
            myPosition.X++;
        }

        public void moveDown()
        {
            myPosition.Y++;
        }

        public void moveUp()
        {
            myPosition.Y--;
        }

    }
}
