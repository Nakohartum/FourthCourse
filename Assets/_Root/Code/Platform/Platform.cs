using _Root.Code.Input;
using _Root.Code.UI;

namespace _Root.Code.Platform
{
    public class Platform : IPlatform
    {
        public IInput Input { get; }
        public IWindow Window { get; }

        public Platform(IInput input, IWindow window)
        {
            Input = input;
            Window = window;
        }
    }
}