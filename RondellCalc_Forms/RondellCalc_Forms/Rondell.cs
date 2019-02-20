using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondellCalc_Forms
{
    public class Rondell
    {
        public int StoneCount { get; set; }

        /// <summary>
        /// Steinkantenlänge [m]
        /// </summary>
        public double StoneLength { get; set; }


        public double SegmentAngle
        {
            get
            {
                return 360.0 / StoneCount;
            }
        }

        public double MaxRadius
        {
            get
            {
                return StoneLength / Math.Sin(SegmentAngle.ToRadian());
            }
        }

        public double MinRadius
        {
            get
            {
                return Math.Sin((90 - SegmentAngle).ToRadian()) * StoneLength / Math.Sin(SegmentAngle.ToRadian());
            }
        }

        public double MaxDiameter
        {
            get
            {
                return MaxRadius * 2;;
            }
        }

        public double MinDiameter
        {
            get
            {
                return MinRadius * 2; ;
            }
        }
    }
}
