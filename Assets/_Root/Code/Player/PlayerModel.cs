using System;
using _Root.Code.Health;
using UnityEngine;

namespace Asteroids
{
    [Serializable]
    public class PlayerModel
    {
        public float Speed;
        public float Acceleration;
        public Health Hp;
        public Rigidbody2D Bullet;
        public Transform Barrel;
        public float Force;
        public Rigidbody2D Rigidbody;
    }
}