using UnityEngine;

namespace _Root.Code.Enemy
{
    public class AsteroidFactory : ICreatorEnemy
    {
        public Enemy Create(Health.Health hp, Transform rootObject)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Initialize(hp, rootObject);
            return enemy;
        }
    }
}