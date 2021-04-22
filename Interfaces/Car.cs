using System;

namespace Interfaces
{
    class Car : ICar, IService
    {
        public double Speed { get; set; }
        public double Power { get; set; }
        public void Accelerate()
        {
            Speed += 2;
        }

        public void Accelerate(double amount)
        {
            Speed += amount;
        }

        public void Charge()
        {
            Console.WriteLine("Your bill is £50");
        }

        public void PowerUp()
        {
            Power += 5;
        }

        public void Service()
        {
            Power += 20;
        }

        public void Start()
        {
            Power -= 1;
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }
    }
}
