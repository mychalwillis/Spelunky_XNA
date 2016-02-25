using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelunky_Config
{
    class oMenuBottom
    {
        private Texture2D tex;

        //Load sprite "sMenuBottom"
        public void Load(Texture2D texture)
        {
            tex = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 72, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 72, 16, 16), Color.White);
        }

        public void Draw2(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(136, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(152, 120, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(168, 120, 16, 16), Color.White);
        }

        public void Draw3(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(72, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(136, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(152, 168, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(168, 168, 16, 16), Color.White);
        }

        public void Draw4(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(24, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(40, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(56, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(152, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(168, 224, 16, 16), Color.White);
        }

        public void Draw5(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Rectangle(72, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(88, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(104, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(120, 224, 16, 16), Color.White);
            spriteBatch.Draw(tex, new Rectangle(136, 224, 16, 16), Color.White);
        }
    }
}
