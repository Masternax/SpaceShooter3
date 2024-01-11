using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter2
{
    internal abstract class MovingObject:GameObject
    {
        protected Vector2 speed;

        public MovingObject(Texture2D texture, float X, float Y, float speedX, float speedY):base(texture,X,Y)
        {
            speed.X = speedX;
            speed.Y = speedY;
        }
    }
}
