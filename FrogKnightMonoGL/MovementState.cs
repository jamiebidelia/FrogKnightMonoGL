using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrogKnightMonoGL
{
    class MovementState
    {
        public bool LeftActivated { get; set; }
        public bool RightActivated { get; set; }
        public bool JumpingUp { get; set; }
        public bool FallingDown { get; set; }
        public bool Crouching { get; set; }

        //By default, we are not moving
        public MovementState()
        {
            LeftActivated = false;
            RightActivated = false;
            JumpingUp = false;
            FallingDown = false;
            Crouching = false;
        }


        //We need to make sure the character isn't trying to move left and right at the same time.
        public bool validLeftRight()
            {
            if (LeftActivated && RightActivated)
                return false;

            return true;
            }


        //HELPER METHODS:
        //These aren't complicated, but having a consistent place to check the logic should make the control code easier.

        //This is just a nice way to transition from jumping to falling.
        public void jumpingToFalling()
        {
            if (JumpingUp)
            {
                JumpingUp = false;
                FallingDown = true;
            }
        }


        //If we're falling, stop that.
        public void hitGround()
        {
            if (FallingDown)
            {
                FallingDown = false;
            }
        }

        //We might need to stand up during cutscenes.
        public void standUp()
        {
            if (Crouching)
            {
                Crouching = false;
            }
        }

    }
}
