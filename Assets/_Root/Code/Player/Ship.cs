using UnityEngine;
using _Root.Code.Fire;

namespace Asteroids
{
    public class Ship : IMove, IRotation, IFireable
    {
        private readonly IMove _moveImplementation;
        private readonly IRotation _rotationImplementation;
        private readonly IFireable _fireImplementation;
        public float Speed => _moveImplementation.Speed;

        public Ship(IMove moveImplementation, IRotation rotationImplementation, IFireable fireImplementation)
        {
            _moveImplementation = moveImplementation;
            _rotationImplementation = rotationImplementation;
            _fireImplementation = fireImplementation;
        }
        
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplementation.Move(horizontal, vertical, deltaTime);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void IncreaseSpeed(float value)
        {
            _moveImplementation.IncreaseSpeed(value);
        }

        public void DecreaseSpeed(float value)
        {
            _moveImplementation.DecreaseSpeed(value);
        }

        public void Shoot(Vector3 startPosition, Quaternion startRotation, Vector3 direction, float force)
        {
            _fireImplementation.Shoot(startPosition, startRotation, direction, force);
        }
    }
}