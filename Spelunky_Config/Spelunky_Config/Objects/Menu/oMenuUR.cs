using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oMenuUR
    {
        private Texture2D tex;

        //Load sprite "sMenuUR"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(104, 16, 16, 17), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(184, 80, 16, 17), Color.White);
        }

        public void Draw3(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(184, 128, 16, 17), Color.White);
        }

        public void Draw4(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(184, 176, 16, 17), Color.White);
        }
    }
}
