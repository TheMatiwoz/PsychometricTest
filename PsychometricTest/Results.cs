using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PsychometricTest
{
    public partial class Results : Form
    {
        private List<Label> labels = new List<Label>();
        private int i = 0;
        private String passed;
        public Results()
        {
            InitializeComponent();
            InitializeDescriptionLabel();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Numer testu";
            chart1.ChartAreas[0].AxisY.Title = "Czas[ms]";
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = Math.Max(Form1.globalResults.Max() + 300, 1000);
            chart1.ChartAreas[0].CursorY.Position = 900;
            chart1.Series["Wyniki testów"].IsValueShownAsLabel = true;
            chart1.Series["Wyniki testów"].Points.DataBindY(Form1.globalResults);
        }
        private void InitializeDescriptionLabel()
        {
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            foreach(long test in Form1.globalResults)
            {

                if(test < 900 && test > 0)
                {
                    passed = "ZALICZONY";
                    labels[i].ForeColor = Color.Green;
                }
                else if(test > 900)
                {
                    passed = "NIEZALICZONY";
                    labels[i].ForeColor = Color.Red;
                }
                else
                {
                    passed = "TEST NIEZREALIZOWANY";
                }
                labels[i].Text = "Wynik testu " + (i + 1) + ":  " + passed;
                i++;
            }
            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
