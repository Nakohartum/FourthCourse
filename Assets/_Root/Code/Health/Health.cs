using UnityEngine;

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

        public void ChangeCurrentHealth(float amount)
        {
            Current = amount;
        }
    }
}