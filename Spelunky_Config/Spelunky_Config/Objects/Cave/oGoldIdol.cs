﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Spelunky_Config
{
    class oGoldIdol
    {
        private Texture2D tex;

        //Load sprite "sGoldIdol"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(96, 256, 16, 16), Color.White);
        }
    }
}
