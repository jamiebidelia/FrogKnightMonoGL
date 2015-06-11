using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System.Diagnostics;



namespace FrogKnightMonoGL
{
    /** <summary>
        This class is the core game launcher.  It contains instances of each
        class needed for game effects, such as audio, control, characters, etc.
        It also gets the game started in the beginning.
        </summary> */
    public class FrogKnight : Game
    {

        Character mainCharacter;
        Controller controller;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Jukebox jukeBox;

        Texture2D titleLogo;
        Texture2D frogImage;


        /** <summary>
            The Constructor creates a new graphics manager.  The rest of the initialization code is handled by Initialize().
        </summary> */
        public FrogKnight()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            controller = new Controller();
            mainCharacter = new Character();

            //For testing moving around the screen.
            mainCharacter.myPosition.X = 300;
            mainCharacter.myPosition.Y = 100;

            Content.RootDirectory = "Content";
            jukeBox = new Jukebox(this);

            titleLogo = Content.Load<Texture2D>("Images/FrogKnightTitle.png");
            frogImage = Content.Load<Texture2D>("Images/FrogKnight.png");

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

        /** <summary>
            Update() is called every update cycle giving us a place to change the game state.
            Here we read the controller input and movement of the character.  We then update
            the global game state.
            </summary>
            <param name="gameTime">Provides a snapshot of timing values.</param>*/
        protected override void Update(GameTime gameTime)
        {
            controller.KeyCheck(this);
            mainCharacter.move(controller);

            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            float scale = 0.25f;


            spriteBatch.Begin();

            spriteBatch.Draw(titleLogo, new Vector2(100, 001), Color.White);

            spriteBatch.Draw(frogImage, new Vector2(mainCharacter.myPosition.X, mainCharacter.myPosition.Y), null, Color.White, 0.0f, Vector2.Zero, scale, SpriteEffects.None, 0.0f);

            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
