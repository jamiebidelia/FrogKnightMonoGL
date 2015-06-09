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
        /*public bool LeftActivated { get; set; }
        public bool RightActivated { get; set; }
        public bool JumpingUp { get; set; }
        public bool FallingDown { get; set; }
        public bool Crouching { get; set; }*/

        public bool LeftPressed { get; set; }
        public bool RightPressed { get; set; }
        public bool CrouchPressed { get; set; }


        /**In the constructor, set all "pressed"s to false.*/
        public Controller()
        {
            LeftPressed = false;
            RightPressed = false;
            CrouchPressed = false;
        }

        public void KeyCheck()
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
        }

    }
}
