using Entity;
using Helper;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TankWars
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public static Game1 Instance { get; private set; }
        public static Viewport Viewport { get { return Instance.GraphicsDevice.Viewport; } }
        public static Vector2 ScreenSize { get { return new Vector2(Viewport.Width, Viewport.Height); } }

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;
        private float LinearVelocity = 4f;

        public Game1()
        {
            Instance = this;
            graphics = new GraphicsDeviceManager(this);
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

            base.Initialize();
            player = new Player()
            {
                Image = Art.TankBody,
                Turret = Art.TankTurret,
                Position = ScreenSize / 2,
                Radius = 10
            };
            EntityManager.Add(player);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Art.Load(Content);


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Draft input testing
            //else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            //{
            //    player.Position = new Vector2(player.Position.X - 1, player.Position.Y);
            //}
            //else if (Keyboard.GetState().IsKeyDown(Keys.Right))
            //{
            //    player.Position = new Vector2(player.Position.X + 1, player.Position.Y);
            //}
            //else if (Keyboard.GetState().IsKeyDown(Keys.Up))
            //{
            //    player.Position = new Vector2(player.Position.X, player.Position.Y - 1);
            //}
            //else if (Keyboard.GetState().IsKeyDown(Keys.Down))
            //{
            //    player.Position = new Vector2(player.Position.X, player.Position.Y + 1);
            //}
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                player.Orientation -= MathHelper.ToRadians(3f);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                player.Orientation += MathHelper.ToRadians(3f);
            }
            var direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90)-player.Orientation), -(float)Math.Sin(MathHelper.ToRadians(90) - player.Orientation));
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                player.Position += direction * LinearVelocity;
            }
            // TODO: Add your update logic here
            EntityManager.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            EntityManager.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
