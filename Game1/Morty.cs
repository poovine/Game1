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
    class Morty : GameObject
    {
        public Texture2D MortyTexture { get { return spriteTexture; } set { spriteTexture = value; } }
        

        public Morty()
        {
            path = "morty";

            if (this.content == null)
                this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
            
            spriteTexture = content.Load<Texture2D>(path);
        }



        internal override void LoadContent()
        {

            // this.content = new ContentManager(content.ServiceProvider, "Content");
            //base.LoadContent(content);
            Console.WriteLine("This is a test");
        }

        internal override void UnLoadContent()
        {
            base.UnLoadContent();
        }

        internal override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(MortyTexture, Vector2.Zero, Color.White);
            //base.Draw(spriteBatch);
        }
    }
}
