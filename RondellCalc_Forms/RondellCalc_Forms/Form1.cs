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

            double stoneLenght = 0;

            if (double.TryParse(txt_StoneLengthA.Text, out stoneLenght))
                data.StoneLengthA = stoneLenght / 100; //cm -> m
            else
                MessageBox.Show("Eingegebener Wert für die Kantelänge A ist fehlerhaft.\nEingabe überprüfen.",
                    "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (double.TryParse(txt_StoneLengthB.Text, out stoneLenght))
                data.StoneLengthB = stoneLenght / 100; //cm -> m
            else
                MessageBox.Show("Eingegebener Wert für die Kantelänge B ist fehlerhaft.\nEingabe überprüfen.",
                    "Fehlerhafte Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            m_Controller.Input = data;

            var result = m_Controller.Calc();

            txt_StoneCount.Text = result.StoneCount.ToString();
            txt_MaxOuterDiameter.Text = result.MaxDiameter.ToString("f3");
            txt_MinOuterDiameter.Text = result.MinDiameter.ToString("f3");
            txt_SegmentAngle.Text = result.SegmentAngle.ToString("f2");
        }
    }
}
