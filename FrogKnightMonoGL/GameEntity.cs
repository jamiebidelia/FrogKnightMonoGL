using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/** 
    <summary>
    This class represents each thing that can appear in the game world.
    This includes characters, map tiles, event triggers, and lights.
    </summary>
*/

namespace FrogKnightMonoGL
{
    class GameEntity
    {
        public Position MyPosition;
        public BoundingSphere MySphere;

        public GameEntity()
        {
            MyPosition = new Position();
            MySphere = new BoundingSphere();
        }

        
    }
}
