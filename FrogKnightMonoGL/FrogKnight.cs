using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System.Diagnostics;


//June 18, 2015:  Today I want to work on building a basic collision detection system.
//It does not have to be finished, but it does have to work a limited domain.



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
        GameEntity titleEntity;  //For showing the title.

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

            titleEntity = new GameEntity();
            titleEntity.MyPosition.X = 100;
            titleEntity.MyPosition.Y = 1;

            //For testing moving around the screen.
            mainCharacter.MyPosition.X = 300;
            mainCharacter.MyPosition.Y = 100;

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


            //This shows that the basic collision detection does work.  However there is a lot to be desired.
            //It currently does not stop the character from moving over objects.
            //It merely knows it is happening.
            //I would like to find a better way to visualize the circles and squares we want to create with collision detection.
            //This may require some thinking on my part.
            if ( CollisionDetection.areColliding(mainCharacter, titleEntity) )
                {
                    Exit();
                }

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

            spriteBatch.Draw(titleLogo, new Vector2(titleEntity.MyPosition.X, titleEntity.MyPosition.Y), Color.White);

            spriteBatch.Draw(frogImage, new Vector2(mainCharacter.MyPosition.X, mainCharacter.MyPosition.Y), null, Color.White, 0.0f, Vector2.Zero, scale, SpriteEffects.None, 0.0f);

            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
