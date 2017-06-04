using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entity
{
    public abstract class GameObject
    {
        protected Texture2D image;
        protected Color color = Color.White;

        public Vector2 Position;
        public Vector2 Velocity;
        public float LivingDuration;
        public float CurrentHealth;
        public float BaseHealth;
        public bool IsInvunerable;
        public bool IsBlocker;
        public float Orientation;
        public float Radius = 20;   // used for circular collision detection
        public bool IsExpired;      // true if the entity was destroyed and should be deleted


        public Vector2 Size
        {
            get
            {
                return image == null ? Vector2.Zero : new Vector2(image.Width, image.Height);
            }
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, Position, null, color, Orientation, Size / 2f, 1f, SpriteEffects.None, 0);
        }
    }
}
