using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipShoter.UI
{ 
    /// <summary>
    /// Simple class to manage(Update, Draw etc.) the Ui.
    /// </summary>
    class GuiDrawer
    {
        private List<IUIElement> UIElemetnts;

        
        public void Update(GameTime gameTime)
        {
            foreach (var element in this.UIElemetnts)
            {
                element.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var element in UIElemetnts)
            {
                element.Draw(spriteBatch);
            }
        }
    } 
}
