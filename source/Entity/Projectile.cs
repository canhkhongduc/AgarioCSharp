using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Projectile : GameObject
    {
        public Player Origin { get; set; }
        public Vector2 StartPosition { get; set; }
        public Vector2 Direction { get; set; }
        public float MaxDistance { get; set; }
        public Projectile(Player origin, Vector2 direction)
        {
            Origin = origin;
            StartPosition = origin.Position;
            MaxDistance = origin.Range;
            Direction = direction;
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
