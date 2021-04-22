namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() { Power = 25, Speed = 0 };
            myCar.PowerUp();
            myCar.Service();
            myCar.Charge();
        }
    }
}
