using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrogKnightMonoGL
{
    class Character : GameEntity
    {
        //public Position myPosition;

        int Lives { get; set; }
        int Health { get; set; }

        const int healthMax = 10;
         


        public Character(Position newPosition)
        {
            Lives = 5;
            Health = 5;
            MyPosition = newPosition;

        }

        public Character()
        {
            Lives = 5;
            Health = 5;
            MyPosition = new Position();
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
            MyPosition.X--;
        }

        public void moveRight()
        {
            MyPosition.X++;
        }

        public void moveDown()
        {
            MyPosition.Y++;
        }

        public void moveUp()
        {
            MyPosition.Y--;
        }

    }
}
