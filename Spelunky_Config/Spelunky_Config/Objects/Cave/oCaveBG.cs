using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Spelunky_Config
{
    class oCaveBG
    {
        private Texture2D tex;

        //Load sprite "sCaveBG"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(128, 16, 32, 32), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 16, 32, 32), Color.White);

            spriteBatch.Draw(tex, new Rectangle(72, 240, 32, 32), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 240, 32, 32), Color.White);

            spriteBatch.Draw(tex, new Rectangle(72, 272, 32, 32), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 272, 32, 32), Color.White);

            spriteBatch.Draw(tex, new Rectangle(128, 48, 32, 32), Color.White);
            spriteBatch.Draw(tex, new Rectangle(160, 48, 32, 32), Color.White);
        }
    }
}
