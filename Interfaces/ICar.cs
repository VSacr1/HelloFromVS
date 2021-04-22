namespace Interfaces
{
    interface ICar
    {
        void Start();
        void PowerUp();
        void Stop();
        void Accelerate();
        void Accelerate(double amount);
    }
}
