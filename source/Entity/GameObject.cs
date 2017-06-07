using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entity
{
    public abstract class GameObject
    {
        public Texture2D Image { get; set; }
        public Color Color { get; set; } = Color.White;

        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float LivingDuration { get; set; }
        public float CurrentHealth { get; set; }
        public float BaseHealth { get; set; }
        public bool IsInvunerable { get; set; }
        public bool IsBlocker { get; set; }
        public float Orientation { get; set; }
        public float Radius { get; set; } = 20;    // used for circular collision detection
        public bool IsExpired { get; set; }      // true if the entity was destroyed and should be deleted


        public Vector2 Size
        {
            get
            {
                return Image == null ? Vector2.Zero : new Vector2(Image.Width, Image.Height);
            }
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color, Orientation, Size / 2f, 1f, SpriteEffects.None, 0);
        }
    }
}
