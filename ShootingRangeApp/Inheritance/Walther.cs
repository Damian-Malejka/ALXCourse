using ShootingRangeApp.Classes;
using ShootingRangeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp.Inheritance
{
    public class Walther : Guns
    {
        public Walther(double singleShootPrice, int numberOfSingleShoots)
        {
            GunName = GunsTypeNames.WALTHER;
            SingleShootPrice = singleShootPrice;
            NumberOfSingleShoots = numberOfSingleShoots;
        }
    }
}