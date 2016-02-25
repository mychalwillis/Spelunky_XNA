using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oMenuRight
    {
        private Texture2D tex;

        //Load sprite "sMenuRight"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(104, 32, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 48, 16, 16), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(104, 56, 16, 16), Color.White);
        }

        public void Draw3(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(184, 96, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(184, 104, 16, 16), Color.White);
        }

        public void Draw4(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(184, 144, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(184, 152, 16, 16), Color.White);
        }

        public void Draw5(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(184, 192, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(184, 208, 16, 16), Color.White);
        }
    }
}
