using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oCaveTop
    {
        private Texture2D tex;

        //Load sprite "sCaveTop"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(128, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(144, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(176, 72, 16, 16), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(72, 288, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 288, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 288, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 288, 16, 16), Color.White);
        }
    }
}
