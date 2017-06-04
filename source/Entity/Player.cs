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
        public float Damage { get; set; }
        public float Range { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Bonus> Bonuses { get; set; } = new List<Bonus>();
        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
