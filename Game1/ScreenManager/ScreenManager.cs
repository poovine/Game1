using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Game1
{
    //Master class for DrawingToScreen 
    class ScreenManager

    {
        private static ScreenManager instance;

        private MainMenuRender mainMenu;
        private SubMenuRender subMenu;
        private GameRender gameRender;
        private GameSetup gameSetup;
        private SplashScreenRender splashScreen;

        private ContentManager content;      

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }

                return instance;
            }          
        }

        public ScreenManager()
        {
            splashScreen = new SplashScreenRender();
            mainMenu = new MainMenuRender();
            gameSetup = new GameSetup();
            gameRender = new GameRender();
            subMenu = new SubMenuRender();
        }

        public void LoadContent(ContentManager content)
        {
            this.content = content;
            switch (Game1.gameState)
            {
                case Game1.GameState.GameRender:
                    {
                        gameRender.LoadContent();
                    }
                    break;
                case Game1.GameState.SubMenu:
                    {
                        subMenu.LoadContent();
                    }
                    break;
                case Game1.GameState.MainMenu:
                    {
                        mainMenu.LoadContent();
                    }
                    break;
                case Game1.GameState.GameSetup:
                    {
                        gameSetup.LoadContent();
                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {
                        splashScreen.LoadContent();
                    }
                    break;
            }
        }

        public void UnLoadContent()
        {
            switch (Game1.gameState)
            {
                case Game1.GameState.GameRender:
                    {
                        gameRender.UnLoadContent();
                    }
                    break;
                case Game1.GameState.SubMenu:
                    {
                        subMenu.UnLoadContent();
                    }
                    break;
                case Game1.GameState.MainMenu:
                    {
                        mainMenu.UnLoadContent();
                    }
                    break;
                case Game1.GameState.GameSetup:
                    {
                        gameSetup.UnLoadContent();
                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {
                        splashScreen.UnLoadContent();
                    }
                    break;
            }
        }

        public void Update(GameTime gameTime)
        {
            switch (Game1.gameState)
            {
                case Game1.GameState.GameRender:
                    {
                        gameRender.Update(gameTime);
                    }
                    break;
                case Game1.GameState.SubMenu:
                    {
                        subMenu.Update(gameTime);
                    }
                    break;
                case Game1.GameState.MainMenu:
                    {
                        mainMenu.Update(gameTime);
                    }
                    break;
                case Game1.GameState.GameSetup:
                    {
                        gameSetup.Update(gameTime);
                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {
                        splashScreen.Update(gameTime);
                    }
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (Game1.gameState)
            {
                case Game1.GameState.GameRender:
                    {
                        gameRender.Draw(spriteBatch);
                    }
                    break;
                case Game1.GameState.SubMenu:
                    {
                        subMenu.Draw(spriteBatch);
                    }
                    break;
                case Game1.GameState.MainMenu:
                    {
                        mainMenu.Draw(spriteBatch);
                    }
                    break;
                case Game1.GameState.GameSetup:
                    {
                        gameSetup.Draw(spriteBatch);
                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {
                        splashScreen.Draw(spriteBatch);
                    }
                    break;
            }
        }
    }
}
