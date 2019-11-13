using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShipShoter.Scenes
{
    class GameScene : Scene
    {
        Sprite ship;
        public GameScene(GameServiceContainer gameServiceContainer) : base(gameServiceContainer)
        {
        }

        public override void LoadContent()
        {
            ship = new Sprite(contentManager.Load<Texture2D>("playerShip3_red"));
            base.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            ship.Draw(spriteBatch);
            base.Draw(spriteBatch);
        }
    }
}
