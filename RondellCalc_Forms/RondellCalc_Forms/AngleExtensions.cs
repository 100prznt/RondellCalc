using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondellCalc_Forms
{
    public static class AngleExtensions
    {
        public static double ToRadian(this double degree)
        {
            return Math.PI * degree / 180.0;
        }

        public static double ToDegree(this double radian)
        {
            return radian * (180.0 / Math.PI);
        }
    }
}
