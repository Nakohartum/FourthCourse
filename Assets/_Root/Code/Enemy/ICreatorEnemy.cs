using UnityEngine;

namespace _Root.Code.Enemy
{
    public interface ICreatorEnemy
    {
        Enemy Create(Health.Health hp, Transform rootObject);
    }
}