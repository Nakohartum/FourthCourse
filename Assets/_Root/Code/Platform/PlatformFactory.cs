using _Root.Code.Input;
using _Root.Code.UI;
using UnityEngine;

namespace _Root.Code.Platform
{
    public class PlatformFactory
    {
        private readonly InputFactory _inputFactory;
        private readonly WindowFactory _windowFactory;

        public PlatformFactory(InputFactory inputFactory, WindowFactory windowFactory)
        {
            _inputFactory = inputFactory;
            _windowFactory = windowFactory;
        }

        public Platform Create(RuntimePlatform platform)
        {
            return new Platform(_inputFactory.CreateInput(platform), _windowFactory.CreateWindow(platform));
        }
    }
}