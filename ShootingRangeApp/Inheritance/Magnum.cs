using ShootingRangeApp.Classes;
using ShootingRangeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp.Inheritance
{
    public class Magnum : Guns
    {
        public double MultipleShootPrice;
        public int NumberOfMultipleShoots;

        public Magnum(double singleShootPrice, int numberOfSingleShoots, int numberOfMultipleShoots)
        {
            GunName = GunsTypeNames.MAGNUM;
            SingleShootPrice = singleShootPrice;
            MultipleShootPrice = SingleShootPrice + (SingleShootPrice * 0.15);
            NumberOfSingleShoots = numberOfSingleShoots;
            NumberOfMultipleShoots = numberOfMultipleShoots;
        }
    }
}