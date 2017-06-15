using Helper;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
        public Texture2D CrossHair { get; set; }
        public float Damage { get; set; }
        public float Range { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Bonus> Bonuses { get; set; } = new List<Bonus>();

        public override void Update()
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            // Read current mouse state
            currentMouseState = Mouse.GetState();
            mousePosition = new Vector2(currentMouseState.X, currentMouseState.Y);

            // Draw player's textures
            spriteBatch.Draw(Image, Position, null, Color, Orientation, Size / 2f, 1f, SpriteEffects.None, 0);
            TurretUpdate(spriteBatch);

            //spriteBatch.Draw(Turret, Position, null, Color, Orientation, new Vector2(Turret.Bounds.Center.X + Turret.Bounds.Center.Y) / 2f, 1f, SpriteEffects.None, 0);
            CrosshairUpdate(spriteBatch);
        }

        MouseState currentMouseState;
        Vector2 mousePosition;
        private void TurretUpdate(SpriteBatch spriteBatch)
        {
            Vector2 dPos = this.Position - mousePosition;

            // Calculate the rotation for the turret
            float turretRotation = -(float)Math.Atan2(dPos.X, dPos.Y);
            Vector2 turretPosition = new Vector2(Position.X + 4, Position.Y - 12);
            spriteBatch.Draw(Turret, Position, null, Color, turretRotation, new Vector2(Turret.Width/2f, Turret.Height * 3f / 4f), 1f, SpriteEffects.None, 0);
        }

        private void CrosshairUpdate(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(CrossHair, mousePosition, Color.White);
        }
    }
}
