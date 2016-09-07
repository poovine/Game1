using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    // Game Logic goes here
    class GameManager
    {
        private ContentManager content;

        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }

                return instance;
            }
        }

        public void LoadContent(ContentManager content)
        {
            this.content = content;

            switch (Game1.gameState)
            {
                case Game1.GameState.GameRender:
                    {

                    }
                    break;
                case Game1.GameState.SubMenu:
                    {

                    }
                    break;
                case Game1.GameState.MainMenu:
                    {

                    }
                    break;
                case Game1.GameState.GameSetup:
                    {

                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {

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

                    }
                    break;
                case Game1.GameState.SubMenu:
                    {

                    }
                    break;
                case Game1.GameState.MainMenu:
                    {

                    }
                    break;
                case Game1.GameState.GameSetup:
                    {

                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {

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

                    }
                    break;
                case Game1.GameState.SubMenu:
                    {

                    }
                    break;
                case Game1.GameState.MainMenu:
                    {

                    }
                    break;
                case Game1.GameState.GameSetup:
                    {

                    }
                    break;
                case Game1.GameState.SplashScreen:
                    {

                    }
                    break;
            }
        }

        //public void Draw(SpriteBatch spriteBatch)
        //{

        //}
    }
}
