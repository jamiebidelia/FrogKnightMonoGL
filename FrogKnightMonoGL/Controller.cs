using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


/**
    This class is to be used for any complicated controller tricks, such as locking input when a key has been pressed down, etc.
    We want to encapsulate all of the input stuff in this class so that the rest of the game has an easy interface to the controls.

*/


namespace FrogKnightMonoGL
{
    class Controller
    {
        public bool LeftPressed { get; set; }
        public bool RightPressed { get; set; }
        public bool JumpingUp { get; set; }
        public bool FallingDown { get; set; }
        public bool CrouchPressed { get; set; }


        /**In the constructor, set all "pressed"s to false.*/
        public Controller()
        {
            LeftPressed = false;
            RightPressed = false;
            JumpingUp = false;
            FallingDown = false;
            CrouchPressed = false;
        }

        public void KeyCheck(FrogKnight gameState)
        {

            KeyboardState keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.A) && LeftPressed == false)
            {
                LeftPressed = true;
                Debug.WriteLine("A key is down.");
            }

            if (keyState.IsKeyUp(Keys.A) && LeftPressed == true)
            {
                LeftPressed = false;
                Debug.WriteLine("A key is up.");
            }

            if (keyState.IsKeyDown(Keys.D) && RightPressed == false)
            {
                RightPressed = true;
                Debug.WriteLine("D key is down.");
            }

            if (keyState.IsKeyUp(Keys.D) && RightPressed == true)
            {
                RightPressed = false;
                Debug.WriteLine("D key is up.");
            }

            if (keyState.IsKeyDown(Keys.S) && CrouchPressed == false)
            {
                CrouchPressed = true;
                Debug.WriteLine("S key is down.");
            }

            if (keyState.IsKeyUp(Keys.S) && CrouchPressed == true)
            {
                CrouchPressed = false;
                Debug.WriteLine("S key is up.");
            }

            if (keyState.IsKeyDown(Keys.W) && JumpingUp == false)
            {
                JumpingUp = true;
                Debug.WriteLine("W key is down.");
            }

            if (keyState.IsKeyUp(Keys.W) && JumpingUp == true)
            {
                JumpingUp = false;
                Debug.WriteLine("W key is up.");
            }




            //Exit the game if pressed.
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                gameState.Exit();
            }
        }




        //We need to make sure the character isn't trying to move left and right at the same time.
        public bool validLeftRight()
        {
            if (LeftPressed && RightPressed)
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
            if (CrouchPressed)
            {
                CrouchPressed = false;
            }
        }

    }
}
