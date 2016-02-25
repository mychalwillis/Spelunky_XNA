using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oConfigLogo
    {
        private Texture2D tex;

        //Load sprite "sConfigLogo"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(128, 16, 64, 48), Color.White);
        }
    }
}
