using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public enum BonusType
    {
        HEALTH,
        SPEED
    }
    public class Bonus : SkillEffect
    {
        public object Value { get; set; }
        public float Duration { get; set; }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
