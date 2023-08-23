using UnityEngine;

namespace _Root.Code.Fire
{
    public interface IFireable
    {
        public void Shoot(Vector3 startPosition, Quaternion startRotation, Vector3 direction, float force);
    }
}