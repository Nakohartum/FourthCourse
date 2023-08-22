using System;
using _Root.Code.Enemy;
using _Root.Code.Pool;
using UnityEngine;

namespace _Root.Code
{
    public class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.Activate(Vector3.one, Quaternion.identity);
        }
    }
}