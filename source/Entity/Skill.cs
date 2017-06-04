using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public enum SkillType {
        GRANT_BONUS,
        EQUIPMENT,
        ABILITY
    }
    public class Skill
    {
        public SkillType Type { get; set; }
        public Texture2D Icon { get; set; }
        public SkillEffect Effect { get; set; }
    }
}
