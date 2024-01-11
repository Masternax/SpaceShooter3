using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter2
{
    internal class GoldCoin : PhysicalObject
    {
        double timeToDie;

        public GoldCoin(Texture2D texture, float X, float Y, GameTime gameTime) : base(texture, X, Y, 0, 2f)
        {
            timeToDie = gameTime.TotalGameTime.TotalMilliseconds + 5000;
        }

        public void Update(GameTime gameTime)
        {
            if (timeToDie < gameTime.TotalGameTime.TotalMilliseconds)
            {
                isAlive = false;
            }
        }
    }
}
