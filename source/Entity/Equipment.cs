using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public enum EquipmentType
    {
        MINE,
        ROCKET
    }
    public class Equipment : SkillEffect
    {
        public EquipmentType Type { get; set; }
        public Texture2D Texture { get; set; }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
