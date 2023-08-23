using System;
using UnityEngine;

namespace Asteroids
{
    public class Player : MonoBehaviour
    {
        public PlayerModel PlayerModel;
        public event Action<Collision2D> OnCollideWithPlayer = collision2D => { };

        private void OnCollisionEnter2D(Collision2D other)
        {
            OnCollideWithPlayer(other);
        }
    }

}