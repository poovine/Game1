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
    abstract class Sprite
    {
        protected Texture2D spriteTexture = null;
        protected Vector2 position, origin;
        protected Rectangle sourceRectangle;
        protected float rotation, scale, layerDepth;
        protected ContentManager content = null;
        protected string path;
        protected bool isActive, isVisible;
        

        public Sprite()
        {
            
        }


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
