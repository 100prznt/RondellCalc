using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondellCalc_Forms
{
    public class Rondell
    {

        #region Properties
        /// <summary>
        /// Anzahl der Steine (bzw. Gehwegplatten)
        /// </summary>
        public int StoneCount { get; set; }

        /// <summary>
        /// Steinkantenlänge in cm
        /// Tangential zum Rondell
        /// </summary>
        public double StoneLengthA
        {
            get
            {
                return m_TangentialLenghtInM * 100;
            }
            set
            {
                m_TangentialLenghtInM = value / 100;
            }
        }
        double m_TangentialLenghtInM;

        /// <summary>
        /// Steinkantenlänge in cm
        /// Radial zum Rondell
        /// </summary>
        public double StoneLengthB
        {
            get
            {
                return m_RadialLenghtInM * 100;
            }
            set
            {
                m_RadialLenghtInM = value / 100;
            }
        }
        double m_RadialLenghtInM;

        /// <summary>
        /// Dicke des Beton- oder Kiesbettes unter den Steien in cm
        /// </summary>
        public double ConcreteWidth
        {
            get
            {
                return m_ConcreteWidthInM * 100;
            }
            set
            {
                m_ConcreteWidthInM = value / 100;
            }
        }
            double m_ConcreteWidthInM;

        /// <summary>
        /// Winkel zwischen zwei Steinen in Grad
        /// </summary>
        public double SegmentAngle
        {
            get
            {
                return 360.0 / StoneCount;
            }
        }

        /// <summary>
        /// Maximaler Radius in Metern (gemessen an den äußeren Steinecken)
        /// </summary>
        public double MaxRadius
        {
            get
            {
                return m_TangentialLenghtInM / Math.Sin(SegmentAngle.ToRadian());
            }
        }

        /// <summary>
        /// Minimaler Radius in Metern (gemessen mittig an den Steikanten)
        /// </summary>
        public double MinRadius
        {
            get
            {
                return Math.Sin((90 - SegmentAngle).ToRadian()) * m_TangentialLenghtInM / Math.Sin(SegmentAngle.ToRadian());
            }
        }

        /// <summary>
        /// Maximaler Durchmesser des Rondells in Metern
        /// Gemessen an den äußeren Steinecken
        /// </summary>
        public double MaxDiameter
        {
            get
            {
                return MaxRadius * 2;;
            }
        }

        /// <summary>
        /// Minimaler Durchmesser des Rondells in Metern
        /// Gemessen an den mittleren Steinkanten
        /// </summary>
        public double MinDiameter
        {
            get
            {
                return MinRadius * 2; ;
            }
        }

        public double SingleStoneArea
        {
            get
            {
                var x = Math.Sin(SegmentAngle.ToRadian()) * m_RadialLenghtInM / Math.Sin((90 - SegmentAngle).ToRadian());
                var a1 = (m_TangentialLenghtInM - x) * m_RadialLenghtInM;
                var a2 = x * m_RadialLenghtInM / 2;

                return a1 + a2;
            }
        }

        public double StoneArea
        {
            get
            {
                return SingleStoneArea * StoneCount;
            }
        }

        public double ConcreteVolume
        {
            get
            {
                return StoneArea * m_ConcreteWidthInM;
            }
        }

        #endregion Properties

    }
}
