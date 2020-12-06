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
    public partial class Form1 : Form
    {
        private static List<long> _globalneWyniki;
        public static List<long> globalneWyniki
        {
            get
            {
                return _globalneWyniki;
            }
            set
            {
                _globalneWyniki = value;
            }
        }
        

        List<int> wynikiTest1 = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test1 test1 = new Test1();
            test1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            globalneWyniki.ForEach(Console.WriteLine);
        }
    }
}
