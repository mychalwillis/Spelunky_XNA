using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oMenuUL
    {
        private Texture2D tex;

        //Load sprite "sMenuUL"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(8, 16, 16, 17), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(8, 80, 16, 17), Color.White);
        }

        public void Draw3(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(8, 128, 16, 17), Color.White);
        }

        public void Draw4(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(8, 176, 16, 17), Color.White);
        }
    }
}
