using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RondellCalc_Forms
{
    public partial class Form1 : Form
    {
        Controller m_Controller;

        public Form1()
        {
            InitializeComponent();

            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            Text = string.Format("{0} - v{1}", typeof(Form1).Assembly.GetName().Name, versionInfo.ProductVersion); //Title

            m_Controller = new Controller();
        }

        private void btn_StartCalc_Click(object sender, EventArgs e)
        {
            InputData data = new InputData();

            if (!double.TryParse(txt_OuterDiameter.Text, out data.OuterDiameter))
                MessageBox.Show("Eingegebener Wert für den Außendurchmesser ist fehlerhaft.\nEingabe überprüfen.",
                    "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!double.TryParse(txt_StoneLengthA.Text, out data.StoneLengthA))
                MessageBox.Show("Eingegebener Wert für die Kantelänge A ist fehlerhaft.\nEingabe überprüfen.",
                    "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!double.TryParse(txt_StoneLengthB.Text, out data.StoneLengthB))
                MessageBox.Show("Eingegebener Wert für die Kantelänge B ist fehlerhaft.\nEingabe überprüfen.",
                    "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!string.IsNullOrWhiteSpace(txt_ConcreteWidth.Text) && !double.TryParse(txt_ConcreteWidth.Text, out data.ConcreteWidth))
                MessageBox.Show("Eingegebener Wert für die Höhe des Pflasterbetts ist fehlerhaft.\nEingabe überprüfen.",
                    "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            m_Controller.Input = data;

            var result = m_Controller.Calc();

            if (!string.IsNullOrWhiteSpace(txt_ConcreteWidth.Text) & !string.IsNullOrWhiteSpace(txt_ConcretePackWeight.Text))
            {
                if (double.TryParse(txt_ConcretePackWeight.Text, out double packWeight))
                    txt_ConcretePackCount.Text = m_Controller.CalcConcretePacks(result.ConcreteVolume, packWeight).ToString();
                else
                    MessageBox.Show("Eingegebener Wert für den Betonsackinhalt ist fehlerhaft.\nEingabe überprüfen.",
                        "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_ConcretePackCount.Text = "";
                txt_ConcreteVolumen.Text = "";
            }

            txt_StoneCount.Text = result.StoneCount.ToString();
            txt_MaxOuterDiameter.Text = result.MaxDiameter.ToString("f3");
            txt_MinOuterDiameter.Text = result.MinDiameter.ToString("f3");
            txt_SegmentAngle.Text = result.SegmentAngle.ToString("f2");

            txt_ConcreteVolumen.Text =  (result.ConcreteVolume > 0) ? result.ConcreteVolume.ToString("f3") : "";

            var sketch = new StoneSkatch(result);
            
            pic_Sketch.Image = sketch.DrawSketch(400);
        }
    }
}
