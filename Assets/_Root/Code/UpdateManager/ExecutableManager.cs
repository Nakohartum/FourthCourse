using System.Collections.Generic;

namespace _Root.Code.UpdateManager
{
    public class ExecutableManager : IUpdatable
    {
        private List<IUpdatable> _updatables;

        public ExecutableManager()
        {
            _updatables = new List<IUpdatable>();
        }

        public void AddUpdatable(IUpdatable updatable)
        {
            _updatables.Add(updatable);
        }

        public void RemoveUpdatable(IUpdatable updatable)
        {
            _updatables.Remove(updatable);
        }

        public void Update(float deltaTime)
        {
            foreach (var updatable in _updatables)
            {
                updatable.Update(deltaTime);
            }
        }
    }
}