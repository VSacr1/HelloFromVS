using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInvetoryApp
{
    class ElectricCar : Car
    {
        public double BatteryPower { get; set; }
        public override void PowerUp()
        {
            BatteryPower += 5;
            Console.WriteLine($"Electric car is charging. {BatteryPower}kwH");
        }
    }
}
