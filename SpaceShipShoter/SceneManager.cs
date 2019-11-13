using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShipShoter
{
    // Lehetne Singleton osztály is de most mindegy.
    /// <summary>
    /// Ez az osztály vezérli a Pályákat.
    /// </summary>
    public class SceneManager
    {
        public Stack<Scene> scenes { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scene">Default Scene!</param>
        public SceneManager(Scene scene)
        {
            scenes.Push(scene);
        }

        public void Update(GameTime gameTime)
        {
            this.scenes.Peek().Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.scenes.Peek().Draw(spriteBatch);
        }
        /// <summary>
        ///  Moving to the NextScene!
        /// </summary>
        /// <param name="scene">The Next scene!</param>
        public void NextScene(Scene scene)
        {
            this.scenes.Clear();

            this.scenes.Push(scene);

            this.scenes.Peek().LoadContent();
        }

    }
}