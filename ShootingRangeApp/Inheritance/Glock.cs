using ShootingRangeApp.Classes;
using ShootingRangeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp.Inheritance
{
    public class Glock : Guns
    {
        public Glock(double singleShootPrice, int numberOfSingleShoots)
        {
            GunName = GunsTypeNames.GLOCK;
            SingleShootPrice = singleShootPrice;
            NumberOfSingleShoots = numberOfSingleShoots;
        }
    }
}