using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace RondellCalc_Forms
{
    public class StoneSkatch : INotifyPropertyChanged
    {
        #region Constants
        double SKETCH_SIZE_FACTOR = 0.8;
        int ANGLE_SIZE = 120;

        #endregion Constants

        #region Member


        #endregion Member

        #region Properties
        public int BitmapWidth { get; set; }

        public int BitmapHeight { get; set; }

        public Rondell Rondell { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for StoneSkatch
        /// </summary>
        public StoneSkatch(Rondell rondell)
        {
            Rondell = rondell;
        }

        #endregion Constructor

        #region Services

        public Bitmap DrawSketch(int widthAndHeight)
        {
            double scaling = 0;
            if (Rondell.StoneLengthA > Rondell.StoneLengthB)
                scaling = (widthAndHeight * SKETCH_SIZE_FACTOR) / Rondell.StoneLengthA;
            else
                scaling = (widthAndHeight * SKETCH_SIZE_FACTOR) / Rondell.StoneLengthB;

            int x1 = (int)(widthAndHeight * (1 - SKETCH_SIZE_FACTOR) / 2);
            int y1 = (int)(widthAndHeight * (SKETCH_SIZE_FACTOR + (1 - SKETCH_SIZE_FACTOR) / 2));

            var bmp = new Bitmap(widthAndHeight, widthAndHeight);

            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, widthAndHeight, widthAndHeight);

                var p = new List<Point>();
                p.Add(new Point(x1, y1));
                p.Add(new Point(x1 + (int)(Rondell.StoneLengthA * scaling), y1));
                p.Add(new Point(x1 + (int)(Rondell.StoneLengthA * scaling), y1 - (int)(Rondell.StoneLengthAInner * scaling)));
                p.Add(new Point(x1, y1 - (int)(Rondell.StoneLengthB * scaling)));

                Pen blackPen = new Pen(Color.Black, 1);
                graphics.DrawPolygon(blackPen, p.ToArray());
                graphics.DrawArc(blackPen, p.Last().X - ANGLE_SIZE / 2, p.Last().Y - ANGLE_SIZE / 2, ANGLE_SIZE, ANGLE_SIZE,
                    360 + (float)Rondell.SegmentAngle, 90 - (float)Rondell.SegmentAngle);
                graphics.DrawString("a", new Font("Symbol", 24), new SolidBrush(Color.Black), p.Last().X + ANGLE_SIZE / 12, p.Last().Y + ANGLE_SIZE / 18);
            }


            return bmp;
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
}
