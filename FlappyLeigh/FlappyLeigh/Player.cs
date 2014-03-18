using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace FlappyLeigh
{
    enum PlayerSprites { Leigh, Alberto }
    class Player
    {
        Vector2 playerVec;
        string name;
        Texture2D sprite;
        PlayerSprites choice;
        Rectangle rect;
        double timer = 0;

        public Player(string nameInput, PlayerSprites spriteChoice)
        {
            name = nameInput;
            rect = new Rectangle(50, 0, 32, 32);
            choice = spriteChoice;
        }

        public void Gravity()
        {
            playerVec.Y = (float) ((playerVec.Y) + (-5 * timer)); //Vf = Vi + a*del(t)
            rect.Y = rect.Y - (int)((playerVec.Y * timer) + (0.5 * -5 * timer * timer)); //del(s)= Vi*del(t) + 0.5*a*del(t)^2
        }

        public void Flap()
        {
            playerVec.Y = 30;
        }

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }

        public double Timer
        {
            get { return timer; }
            set { if ((value) >= 0.17)
                    timer = 0.17;
                  else
                    timer = value;
            }
        }
    }
}
