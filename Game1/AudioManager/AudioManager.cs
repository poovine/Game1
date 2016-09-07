using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    //All things audio
    class AudioManager
    {
        private ContentManager content;

        private static AudioManager instance;

        public static AudioManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AudioManager();
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
