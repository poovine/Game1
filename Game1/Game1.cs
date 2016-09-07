using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Game1
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public static ContentManager content;
                

        public static GameState gameState = GameState.GameRender;

        public enum GameState
        {
            SplashScreen,
            MainMenu,
            GameSetup,
            GameRender,
            SubMenu
        }      


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            content = Content;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            InputManager.Instance.LoadContent(Content);
            GameManager.Instance.LoadContent(Content);
            ScreenManager.Instance.LoadContent(Content);
            AudioManager.Instance.LoadContent(Content);
        }

        protected override void UnloadContent()
        {
            InputManager.Instance.UnLoadContent();
            GameManager.Instance.UnLoadContent();
            ScreenManager.Instance.UnLoadContent();
            AudioManager.Instance.UnLoadContent();

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            InputManager.Instance.Update(gameTime);
            GameManager.Instance.Update(gameTime);
            ScreenManager.Instance.Update(gameTime);
            AudioManager.Instance.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
