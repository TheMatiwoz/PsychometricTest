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
    public partial class Test2 : Form
    {
        private int leftDiode;
        private int bottomDiode;
        private List<PictureBox> pictureBox = new List<PictureBox>();
        private long timeDiff;
        private long time;
        private List<long> wyniki = new List<long>();
        public Test2()
        {
            InitializeComponent();
            pictureBox.Add(pictureBox1);
            pictureBox.Add(pictureBox2);
            pictureBox.Add(pictureBox3);
            pictureBox.Add(pictureBox4);
            pictureBox.Add(pictureBox5);
            pictureBox.Add(pictureBox6);
            pictureBox.Add(pictureBox7);
            pictureBox.Add(pictureBox8);
            turnOnDiode();
        }

        private async void turnOnDiode()
        {
            await Task.Delay(new Random().Next(500, 2000));
            Random rnd = new Random();
            leftDiode = rnd.Next(4);
            bottomDiode = rnd.Next(4, 8);
            pictureBox[leftDiode].BackColor = Color.Red;
            pictureBox[bottomDiode].BackColor = Color.Red;
            time = DateTimeOffset.Now.ToUnixTimeMilliseconds();



        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (pictureBox[leftDiode].BackColor == Color.Red && pictureBox[bottomDiode].BackColor == Color.Red && button.Tag.ToString() == (leftDiode.ToString()+bottomDiode.ToString()))
            {
                pictureBox[leftDiode].BackColor = Color.Black;
                pictureBox[bottomDiode].BackColor = Color.Black;
                Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds() + " " + time);
                timeDiff = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
                turnOnDiode();
                wyniki.Add(timeDiff);
                wynikiLenght();
            }
        }

        private async void wynikiLenght()
        {
            if (wyniki.Count >= 7)
            {
                await Task.Delay(1500);
                Form1.globalneWyniki[1] = avg();
                wyniki.ForEach(Console.WriteLine);

                this.Close();
            }
        }

        private long avg()
        {
            long suma = 0;
            foreach(var wynik in wyniki)
            {
                suma += wynik;
            }
            return suma / wyniki.Count;
        }
    }
}
