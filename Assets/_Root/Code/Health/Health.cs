using System;
using Asteroids;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _Root.Code.Health
{
    public class Health
    {
        public float Max { get; }
        public float Current { get; private set; }

        public Health(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHealth(float amount, GameObject go)
        {
            Current = amount;
            if (Current > Max)
            {
                Current = Max;
            }

            if (Current <= 0)
            {
                Die(go);
            }
        }

        private void Die(GameObject go)
        {
            go.SetActive(false);
        }
    }
}