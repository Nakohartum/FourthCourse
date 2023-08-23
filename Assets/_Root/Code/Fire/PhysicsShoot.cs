using UnityEngine;

namespace _Root.Code.Fire
{
    public class PhysicsShoot : IFireable
    {
        public Rigidbody2D _bulletPrefab;

        public PhysicsShoot(Rigidbody2D bulletPrefab)
        {
            _bulletPrefab = bulletPrefab;
        }
        
        public void Shoot(Vector3 startPosition, Quaternion startRotation, Vector3 direction, float force)
        {
            var tempAmmunition = Object.Instantiate(_bulletPrefab, startPosition, startRotation);
            tempAmmunition.AddForce(direction * force);
        }
    }
}