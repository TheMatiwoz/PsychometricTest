using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricTest
{
    public partial class Test1 : Form
    {
        private int buttonNumber;
        private long time;
        private long timeDiff;
        private List<long> results = new List<long>();

        public Test1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            changeButtonColor();
        }

        private void gas_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.Green)
            {
                pictureBox3.BackColor = Color.Black;
                Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds() + " " + time);
                timeDiff = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
                results.Add(timeDiff);
                changeButtonColor();
            }
        }

        private void brake_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                pictureBox1.BackColor = Color.Black;
                Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds() + " " + time);
                timeDiff = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
                results.Add(timeDiff);
                changeButtonColor();
            }
        }

        private void addToTotalMeasurements ()
        {
            if (results.Count >= 5)
            {
                //await Task.Delay(1500);
                Form1.globalResults[0] = avg();
                //wyniki.ForEach(Console.WriteLine);
                this.Close();
            }
        }

        private long avg()
        {
            long sum = 0;
            foreach (var result in results)
            {
                sum += result;
            }
            return sum / results.Count;
        }

        private async void changeButtonColor()
        {
            buttonNumber = new Random().Next(3);
            await Task.Delay(new Random().Next(500, 2000));     //delay of changing colors
            if (buttonNumber == 0)
            {
                pictureBox1.BackColor = Color.Red;
                time = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            }
            else if (buttonNumber == 1)
            {
                pictureBox2.BackColor = Color.Orange;
                await Task.Delay(new Random().Next(500, 2000));
                pictureBox2.BackColor = Color.Black;
                addToTotalMeasurements();
                changeButtonColor();
            }
            else if (buttonNumber == 2)
            {
                pictureBox3.BackColor = Color.Green;
                time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            addToTotalMeasurements();
        }
    }
}
