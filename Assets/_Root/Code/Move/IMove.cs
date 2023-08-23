namespace Asteroids
{
    public interface IMove
    {
        float Speed { get; }
        void Move(float horizontal, float vertical, float deltaTime);
        void IncreaseSpeed(float value);
        void DecreaseSpeed(float value);
    }
}