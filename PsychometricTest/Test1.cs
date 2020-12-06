using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricTest
{
    public partial class Test1 : Form
    {
        private int buttonNumber;
        private long time;
        private long timeDiff;
        private List<long> wyniki = new List<long>();
        public Test1()
        {
            InitializeComponent();
            buttonColor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pictureBox3.BackColor == Color.Green)
            {
                pictureBox3.BackColor = Color.Black;
                Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds() + " " + time);
                timeDiff = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
                wyniki.Add(timeDiff);
                buttonColor();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                pictureBox1.BackColor = Color.Black;
                Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds() + " " + time);
                timeDiff = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
                wyniki.Add(timeDiff);
                buttonColor();
            }
        }
        private void wynikiLenght()
        {
            if(wyniki.Count >= 5)
            {
                Form1.globalneWyniki = wyniki;
                wyniki.ForEach(Console.WriteLine);

                this.Close();
            }
        }

        private async void buttonColor()
        {
            buttonNumber = new Random().Next(3);
            await Task.Delay(new Random().Next(500, 2000));
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
                buttonColor();
            }
            else if (buttonNumber == 2)
            {
                pictureBox3.BackColor = Color.Green;
                time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }

            wynikiLenght();
        }

        private void print(String x)
        {
            System.Console.WriteLine(x);
        }

    }
}
