using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//TODO
//better shape of Form1
//rounded traffics in test 1

namespace PsychometricTest
{
    public partial class Form1 : Form
    {
        public static long[] globalResults { get; set; } = new long[3];
        
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
        }

        private void test1_Click(object sender, EventArgs e)
        {
            Test1 test1 = new Test1();
            test1.ShowDialog();
        }

        private void test2_Click(object sender, EventArgs e)
        {
            Test2 test2 = new Test2();
            test2.ShowDialog();
        }

        private void test3_Click(object sender, EventArgs e)
        {
            Test3 test3 = new Test3();
            test3.ShowDialog();
        }

        private void results_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Wyniki: " + globalResults[0].ToString() + " 2: " + globalResults[1]);
        }

        private void oProjekcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectInfoForm projectInfoForm = new ProjectInfoForm();
            projectInfoForm.ShowDialog();
        }

        private void oTworcachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)  //event when form closing
        {
            base.OnFormClosing(e);
            if (closeCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool closeCancel()
        {
            const string message = "Czy jestes pewny, ze chcesz zamknac aplikacje?";
            const string caption = "Zamknij aplikacje";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { return true; }
            else
            { return false; }
        }
    }
}
