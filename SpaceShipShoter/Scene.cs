using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShipShoter
{
    public abstract class Scene
    {
        public ContentManager contentManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameServiceContainer">Kell mert minden pályának saját Content Manager kell. Így könnyebb őket kezelni.</param>
        public Scene(GameServiceContainer gameServiceContainer)
        {
            contentManager = new ContentManager(gameServiceContainer);
        }
        public virtual void LoadContent()
        {

        }
        public virtual void UnloadContent()
        {
            // Biztosan megszabaduljunk tőle.
            contentManager.Unload();
            contentManager.Dispose();
            contentManager = null;
        }
        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}