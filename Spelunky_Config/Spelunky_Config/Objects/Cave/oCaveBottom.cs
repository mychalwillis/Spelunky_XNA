using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oCaveBottom
    {
        private Texture2D tex;

        //Load sprite "sCaveDown"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(128, 0, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(144, 0, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 0, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 240, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 240, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(176, 0, 16, 16), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(104, 240, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 240, 16, 16), Color.White);
        }
    }
}
