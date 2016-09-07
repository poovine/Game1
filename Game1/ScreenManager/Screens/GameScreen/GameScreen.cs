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
    abstract class GameScreen 
    {
        protected List<GameObject> gameObjects;
        protected List<GameBackGround> gameBackGround;
        protected List<GameUI> gameUI;

        internal virtual void LoadContent()
        {
        }

        internal virtual void UnLoadContent()
        {
        }

        internal virtual void Update(GameTime gameTime)
        {
        }

        internal virtual void Draw(SpriteBatch spriteBatch)
        {
         
        }
    }
}

