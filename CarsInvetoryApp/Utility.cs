using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInvetoryApp
{
    public static class Utility
    {
        public static string GetDetails(this Car car)
        {
            var profitFromSale = car.SalePrice - car.CostPrice;
            return $"{car.Make} {car.Model} {car.Year} sells for {car.SalePrice:c}. Profit from sale = {profitFromSale:c}";
        }
    }
}
