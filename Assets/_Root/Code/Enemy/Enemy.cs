using System;
using UnityEngine;

namespace _Root.Code.Enemy
{
    public abstract class Enemy : MonoBehaviour
    {
        private Transform _rootObject;
        public Health.Health Health { get; private set; }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Deactivate();
        }

        public static Asteroid CreateAsteroidEnemy(Health.Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public void Initialize(Health.Health hp, Transform rootObject)
        {
            Health = hp;
            _rootObject = rootObject;
        }

        public void Activate(Vector3 position, Quaternion rotation)
        {
            transform.localPosition = position;
            transform.localRotation = rotation;
            gameObject.SetActive(true);
            transform.SetParent(null);
        }

        public void Deactivate()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.SetActive(false);
            transform.SetParent(_rootObject);
        }
    }
}