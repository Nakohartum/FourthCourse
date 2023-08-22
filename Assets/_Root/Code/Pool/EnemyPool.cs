using System;
using System.Collections.Generic;
using System.Linq;
using _Root.Code.Enemy;
using _Root.Code.Managers;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _Root.Code.Pool
{
    public class EnemyPool
    {
        private readonly Dictionary<string, HashSet<Enemy.Enemy>> _enemyPool;
        private readonly int _capacityPool;
        private Transform _rootPool;
        private AsteroidFactory _asteroidFactory;

        public EnemyPool(int capacityPool)
        {
            _asteroidFactory = new AsteroidFactory();
            _enemyPool = new Dictionary<string, HashSet<Enemy.Enemy>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                _rootPool = new GameObject(NameManager.POOL_AMMUNITION).transform;
            }
        }

        public Enemy.Enemy GetEnemy(string type)
        {
            Enemy.Enemy result;
            switch (type)
            {
                case "Asteroid":
                    result = GetAsteroid(GetListEnemies(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "No");
            }

            return result;
        }

        private HashSet<Enemy.Enemy> GetListEnemies(string type)
        {
            return _enemyPool.ContainsKey(type) ? _enemyPool[type] : _enemyPool[type] = new HashSet<Enemy.Enemy>();
        }

        private Enemy.Enemy GetAsteroid(HashSet<Enemy.Enemy> enemies)
        {
            var enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (enemy == null)
            {
                for (int i = 0; i < _capacityPool; i++)
                {
                    var instantiate = _asteroidFactory.Create(new Health.Health(100.0f, 100.0f), _rootPool);
                    instantiate.Deactivate();
                    enemies.Add(instantiate);
                }
                GetAsteroid(enemies);
            }

            enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            return enemy;
        }
        

        public void RemovePool()
        {
            Object.Destroy(_rootPool.gameObject);
        }
    }
}