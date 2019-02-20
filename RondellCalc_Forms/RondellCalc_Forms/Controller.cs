using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace RondellCalc_Forms
{
    public class Controller : INotifyPropertyChanged
    {
        #region Constants
        /// <summary>
        /// Dichte von Beton
        /// </summary>
        const double CONCRETE_DENSITY = 1920;

        #endregion Constants

        #region Member


        #endregion Member

        #region Properties
        public InputData Input { get; set; }

        public Rondell RondellMin { get; set; }

        public Rondell RondellMax { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Controller
        /// </summary>
        public Controller()
        {

        }

        #endregion Constructor

        #region Services

        public Rondell Calc()
        {
            RondellMin = new Rondell() { StoneLengthA = Input.StoneLengthA, StoneLengthB = Input.StoneLengthB, ConcreteWidth = Input.ConcreteWidth };
            RondellMax = new Rondell() { StoneLengthA = Input.StoneLengthA, StoneLengthB = Input.StoneLengthB, ConcreteWidth = Input.ConcreteWidth };

            double stoneCountPrecise = Input.ScopeLength / Input.StoneLengthA * 100; //cm -> m

            RondellMin.StoneCount = (int)Math.Floor(stoneCountPrecise);
            RondellMax.StoneCount = (int)Math.Ceiling(stoneCountPrecise);

            return RondellMax;
        }

        /// <summary>
        /// Berechnet die anzahl benötigter Betonsäcke
        /// </summary>
        /// <param name="volumen">Volumen des fertigen Betons [m³]</param>
        /// <param name="packWeight">Trockenbeton Sackinhalt [kg]</param>
        /// <returns>Anzahl benötigert Säcke</returns>
        public int CalcConcretePacks(double volumen, double packWeight)
        {
            double weight = volumen * CONCRETE_DENSITY;
            double packsPrecise = weight / packWeight;

            return (int)Math.Ceiling(packsPrecise);
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events

        #region INotifyPropertyChanged Member
        /// <summary>
        /// Helpmethod, to call the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propName">Name of changed property</param>
        protected void PropChanged([CallerMemberName] string propName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        /// <summary>
        /// Updated property values available
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

    public struct InputData
    {
        public double OuterDiameter;
        public double StoneLengthA;
        public double StoneLengthB;
        public double ConcreteWidth;

        public double ScopeLength
        {
            get
            {
                return OuterDiameter * Math.PI;
            }
        }
    }
}
