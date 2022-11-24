using ShootingRangeApp.Classes;
using ShootingRangeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp.Inheritance
{
    public class Xm15 : Guns
    {
        public double MultipleShootPrice;
        public int NumberOfMultipleShoots;

        public Xm15(double singleShootPrice, int numberOfSingleShoots, int numberOfMultipleShoots)
        {
            GunName = GunsTypeNames.XM15;
            SingleShootPrice = singleShootPrice;
            MultipleShootPrice = SingleShootPrice + (SingleShootPrice * 0.15);
            NumberOfSingleShoots = numberOfSingleShoots;
            NumberOfMultipleShoots = numberOfMultipleShoots;
        }
    }
}