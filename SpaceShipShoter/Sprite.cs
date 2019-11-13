
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShipShoter
{
    public class Sprite
    {
        public Texture2D Texture { get; private set; }
        public Vector2 Position { get; set; }

        /// <summary>
        /// Returns with the sprite center position!
        /// </summary>
        public Vector2 PositionCenter
        {
            get
            {
                return new Vector2(Texture.Width / 2, Texture.Height / 2);
            }
        }
        public Sprite(Texture2D skin)
        {
            Texture = skin;
            Position = new Vector2(0, 0);
        }

        public Sprite(Texture2D skin, Vector2 position)
        {
            Texture = skin;
            Position = position;
        }

        /// <summary>
        /// Draws the texture at the specified position.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, PositionCenter, 1f, SpriteEffects.None, 0f);
        }
    }
}
