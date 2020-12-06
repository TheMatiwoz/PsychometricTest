using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricTest
{
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            initializeProjectInfoWithText();
        }

        private void initializeProjectInfoWithText()
        {
            String text = "Projekt ma na celu sprawdzenie sprawnosci psychomotorycznej kierowcow. Cały test psychomotoryczny składa się z trzech " +
                "testów - dwóch badających szybkość reakcji na bodźce optyczne oraz jednego badającego szybkośc reakcji na bodźce akustyczne." +
                "Po wykonaniu wszystkich testów istnieje możliwość sprawdzenia wyników - w formie syntetycznej oraz analitycznej.";
            this.projectInfoLabel1.Text = text;
        }
    }
}
