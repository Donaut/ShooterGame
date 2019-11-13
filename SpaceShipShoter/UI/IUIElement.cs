using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShipShoter.UI
{
    interface IUIElement
    {
        void Initialize();
        void Draw(SpriteBatch spriteBatch);
        void Update(GameTime gameTime);
    }
}