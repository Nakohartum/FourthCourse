using UnityEngine;

namespace Asteroids
{
    public class RotationShip : IRotation
    {
        private readonly Transform _transform;

        public RotationShip(Transform transform)
        {
            _transform = transform;
        }

        public void Rotation(Vector3 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}