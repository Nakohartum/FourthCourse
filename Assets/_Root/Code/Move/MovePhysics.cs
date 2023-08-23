using UnityEngine;

namespace Asteroids
{
    public class MovePhysics : IMove
    {
        private readonly Rigidbody2D _rigidbody;
        public float Speed { get; private set; }
        private Vector3 _move;

        public MovePhysics(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            Speed = speed;
        }
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _move.Set(Input.GetAxis("Horizontal") * Speed, Input.GetAxis("Vertical") * Speed, 0f);
            _move.Normalize();
            _rigidbody.velocity = _move;
        }

        public void IncreaseSpeed(float value)
        {
            Speed += value;
        }

        public void DecreaseSpeed(float value)
        {
            Speed -= value;
        }
    }
}