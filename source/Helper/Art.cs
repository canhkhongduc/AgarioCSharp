using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Helper
{
    public static class Art
    {
        public static Texture2D TankBody { get; private set; }
        public static Texture2D TankTurret { get; private set; }
        public static Texture2D Crosshair { get; private set; }
        public static void Load(ContentManager content)
        {
            TankBody = content.Load<Texture2D>("TankBody");
            TankTurret = content.Load<Texture2D>("TankTurret");
            Crosshair = content.Load<Texture2D>("Crosshair");
        }
    }
}
