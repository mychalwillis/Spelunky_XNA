using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Spelunky_Config
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        RenderTarget2D target;

        oBlackBG oBlackBG;
        oBlack oBlack;
        oCaveBG oCaveBG;
        oConfigLogo oConfigLogo;
        oCaveBottom oCaveBottom;
        oGoldIdol oGoldIdol;
        oCaveTop oCaveTop;
        oMenuUL oMenuUL;
        oMenuTop oMenuTop;
        oMenuUR oMenuUR;
        oMenuLeft oMenuLeft;
        oMenuRight oMenuRight;
        oMenuLL oMenuLL;
        oMenuBottom oMenuBottom;
        oMenuLR oMenuLR;
        oAltar oAltar;
        oPlayer oPlayer;
        oDoor oDoor;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 416;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            oBlackBG = new oBlackBG();
            oBlack = new oBlack();
            oCaveBG = new oCaveBG();
            oConfigLogo = new oConfigLogo();
            oCaveBottom = new oCaveBottom();
            oGoldIdol = new oGoldIdol();
            oCaveTop = new oCaveTop();
            oMenuUL = new oMenuUL();
            oMenuTop = new oMenuTop();
            oMenuUR = new oMenuUR();
            oMenuLeft = new oMenuLeft();
            oMenuRight = new oMenuRight();
            oMenuLL = new oMenuLL();
            oMenuBottom = new oMenuBottom();
            oMenuLR = new oMenuLR();
            oAltar = new oAltar();
            oPlayer = new oPlayer();
            oDoor = new oDoor();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            target = new RenderTarget2D(GraphicsDevice, 208, 300);

            // TODO: use this.Content to load your game content here

            oBlackBG.Load(Content.Load<Texture2D>("Sprites\\sBlack"));
            oBlack.Load(Content.Load<Texture2D>("Sprites\\sBlack"));
            oCaveBG.Load(Content.Load<Texture2D>("Sprites\\Cave\\sCaveBG"));
            oConfigLogo.Load(Content.Load<Texture2D>("Sprites\\Cave\\sConfigLogo"));
            oCaveBottom.Load(Content.Load<Texture2D>("Sprites\\Cave\\sCaveDown"));
            oGoldIdol.Load(Content.Load<Texture2D>("Sprites\\Cave\\sGoldIdol"));
            oCaveTop.Load(Content.Load<Texture2D>("Sprites\\Cave\\sCaveTop"));
            oMenuUL.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuUL"));
            oMenuTop.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuTop"));
            oMenuUR.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuUR"));
            oMenuLeft.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuLeft"));
            oMenuRight.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuRight"));
            oMenuLL.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuLL"));
            oMenuBottom.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuBottom"));
            oMenuLR.Load(Content.Load<Texture2D>("Sprites\\Other\\sMenuLR"));
            oAltar.Load(Content.Load<Texture2D>("Sprites\\Cave\\sAltar"));
            oPlayer.Load(Content.Load<Texture2D>("Sprites\\Cave\\sPlayer"));
            oDoor.Load(Content.Load<Texture2D>("Sprites\\Cave\\sDoor"));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.SetRenderTarget(target);
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            oBlackBG.Draw(spriteBatch);
            oBlack.Draw(spriteBatch);
            oCaveBG.Draw(spriteBatch);
            oConfigLogo.Draw(spriteBatch);
            oCaveBottom.Draw(spriteBatch);
            oGoldIdol.Draw(spriteBatch);
            oCaveTop.Draw(spriteBatch);
            oMenuUL.Draw(spriteBatch);
            oMenuTop.Draw(spriteBatch);
            oMenuUR.Draw(spriteBatch);
            oMenuLeft.Draw(spriteBatch);
            oMenuRight.Draw(spriteBatch);
            oMenuLL.Draw(spriteBatch);
            oMenuBottom.Draw(spriteBatch);
            oMenuLR.Draw(spriteBatch);
            oMenuLeft.Draw2(spriteBatch);
            oMenuRight.Draw2(spriteBatch);
            oMenuUL.Draw2(spriteBatch);
            oMenuTop.Draw2(spriteBatch);
            oMenuUR.Draw2(spriteBatch);
            oMenuLeft.Draw3(spriteBatch);
            oMenuRight.Draw3(spriteBatch);
            oMenuLL.Draw2(spriteBatch);
            oMenuLR.Draw2(spriteBatch);
            oMenuBottom.Draw2(spriteBatch);
            oMenuUL.Draw3(spriteBatch);
            oMenuUR.Draw3(spriteBatch);
            oMenuTop.Draw3(spriteBatch);
            oMenuLeft.Draw4(spriteBatch);
            oMenuRight.Draw4(spriteBatch);
            oMenuLL.Draw3(spriteBatch);
            oMenuLR.Draw3(spriteBatch);
            oMenuBottom.Draw3(spriteBatch);
            oMenuUL.Draw4(spriteBatch);
            oMenuUR.Draw4(spriteBatch);
            oMenuTop.Draw4(spriteBatch);
            oMenuLeft.Draw5(spriteBatch);
            oMenuRight.Draw5(spriteBatch);
            oMenuLL.Draw4(spriteBatch);
            oMenuLR.Draw4(spriteBatch);
            oMenuBottom.Draw4(spriteBatch);
            oCaveTop.Draw2(spriteBatch);
            oAltar.Draw(spriteBatch);
            oPlayer.Draw(spriteBatch);
            oDoor.Draw(spriteBatch);
            oCaveBottom.Draw2(spriteBatch);
            oMenuBottom.Draw5(spriteBatch);

            spriteBatch.End();

            //Set rendering back to the back buffer
            GraphicsDevice.SetRenderTarget(null);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone);

            spriteBatch.Draw(target, new Rectangle(0, 0, 416, 600), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}