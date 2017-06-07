using Helper;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Entity
{
    public enum TankType
    {
        // TODO: add tank types
    }

    public class Player : GameObject
    {
        public TankType Type { get; set; }
        public Texture2D Turret { get; set; }
        public float Damage { get; set; }
        public float Range { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Bonus> Bonuses { get; set; } = new List<Bonus>();
        
        public override void Update()
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color, Orientation, Size / 2f, 1f, SpriteEffects.None, 0);
            spriteBatch.Draw(Turret, Position, null, Color, Orientation, new Vector2(Turret.Width, Turret.Height) / 2f, 1f, SpriteEffects.None, 0);
        }
    }
}
