using ShootingRangeApp.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp.Classes
{
    public abstract class Guns
    {
        public GunsTypeNames GunName;
        public double SingleShootPrice;
        public int NumberOfSingleShoots;

        public Guns()
        {
         
        }
    }
}
