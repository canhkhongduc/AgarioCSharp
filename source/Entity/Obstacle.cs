using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Obstacle : GameObject
    {
        public Obstacle(Vector2 spawnPosition)
        {
            IsBlocker = true;
            IsInvunerable = true; // or false, depending on implementation
            Velocity = Vector2.Zero;
            Position = spawnPosition;
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
