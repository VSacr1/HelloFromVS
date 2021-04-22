using System;

namespace CarsInvetoryApp
{
    class PetrolCar : Car
    {
        public double TankCapacity { get; set; }
        public override void PowerUp()
        {
            TankCapacity += 2;
            Console.WriteLine($"Electric car is filling up. {TankCapacity}litres");

        }
    }
}
