using UnityEngine;

namespace Asteroids
{
    public class MoveTransform : IMove
    {
        private readonly Transform _transform;
        public float Speed { get; protected set; }
        private Vector3 _move;

        public MoveTransform(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = Speed * deltaTime;
            _move.Set(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0f);
            _transform.Translate(_move, Space.World);
        }

        public void IncreaseSpeed(float value)
        {
            Speed += value;
        }

        public void DecreaseSpeed(float value)
        {
            Speed += value;
        }
    }
}