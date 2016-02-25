using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oBlack
    {
        private Texture2D tex;

        //Load sprite "sBlack"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(128, 16, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(144, 16, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 16, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(176, 16, 16, 16), Color.White);

            spriteBatch.Draw(tex, new Rectangle(128, 32, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(144, 32, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 32, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(176, 32, 16, 16), Color.White);

            spriteBatch.Draw(tex, new Rectangle(128, 48, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(144, 48, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 48, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(176, 48, 16, 16), Color.White);

            spriteBatch.Draw(tex, new Rectangle(128, 56, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(144, 56, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 56, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(176, 56, 16, 16), Color.White);

            spriteBatch.Draw(tex, new Rectangle(72, 272, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 272, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 272, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 272, 16, 16), Color.White);

            spriteBatch.Draw(tex, new Rectangle(72, 256, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 256, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 256, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 256, 16, 16), Color.White);

            spriteBatch.Draw(tex, new Rectangle(72, 240, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 240, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 240, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 240, 16, 16), Color.White);
        }
    }
}
