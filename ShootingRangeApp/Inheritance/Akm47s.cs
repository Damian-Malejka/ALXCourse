using ShootingRangeApp.Classes;
using ShootingRangeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp.Inheritance
{
    public class Akm47s : Guns
    {
        public double MultipleShootPrice;
        public int NumberOfMultipleShoots;

        public Akm47s(double singleShootPrice,int numberOfSingleShoots, int numberOfMultipleShoots)
        {
            GunName = GunsTypeNames.AKM47S;
            SingleShootPrice = singleShootPrice;
            MultipleShootPrice = SingleShootPrice + (SingleShootPrice * 0.15);
            NumberOfSingleShoots = numberOfSingleShoots;
            NumberOfMultipleShoots = numberOfMultipleShoots; 
        }
    }
}
