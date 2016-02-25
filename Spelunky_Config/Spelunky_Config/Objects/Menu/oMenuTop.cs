using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oMenuTop
    {
        private Texture2D tex;

        //Load sprite "sMenuTop"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 16, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 16, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 16, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 16, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 16, 16, 17), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(136, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(152, 80, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(168, 80, 16, 17), Color.White);
        }

        public void Draw3(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(136, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(152, 128, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(168, 128, 16, 17), Color.White);
        }

        public void Draw4(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(136, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(152, 176, 16, 17), Color.White);
            spriteBatch.Draw(tex, new Rectangle(168, 176, 16, 17), Color.White);
        }
    }
}
