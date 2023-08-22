using System;
using UnityEngine;

namespace _Root.Code.Input
{
    public class InputFactory
    {
        public IInput CreateInput(RuntimePlatform platform)
        {
            switch (platform)
            {
                case RuntimePlatform.WindowsPlayer:
                case RuntimePlatform.WindowsEditor:
                    return new PCInput();
                case RuntimePlatform.XboxOne:
                case RuntimePlatform.PS4:
                    return new ConsoleInput();
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
    }
}