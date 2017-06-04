using Entity;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankWars
{
    static class EntityManager
    {
        static List<GameObject> gameObjects = new List<GameObject>();
        static bool isUpdating;
        static List<GameObject> addedObjects = new List<GameObject>();

        public static int Count
        {
            get
            {
                return gameObjects.Count;
            }
        }

        public static void Add(GameObject gameObject)
        {
            if (!isUpdating)
                gameObjects.Add(gameObject);
            else
                addedObjects.Add(gameObject);
        }

        public static void Update()
        {
            isUpdating = true;

            foreach (var entity in gameObjects)
                entity.Update();
            isUpdating = false;

            foreach (var gameObject in addedObjects)
                gameObjects.Add(gameObject);

            addedObjects.Clear();

            // remove any expired entities
            gameObjects = gameObjects.Where(x => !x.IsExpired).ToList();
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var entity in gameObjects)
                entity.Draw(spriteBatch);
        }
    }
}
