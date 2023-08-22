using _Root.Code.Input;
using _Root.Code.UI;

namespace _Root.Code.Platform
{
    public interface IPlatform
    {
        IInput Input { get; }
        IWindow Window { get; }
    }
}