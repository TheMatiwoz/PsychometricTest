using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricTest
{
    public partial class Test1 : Form
    {
        private int buttonNumber;
        private long time;
        private long timeDiff;
        private List<long> results = new List<long>(); //each next result of current test is ovewritten on the latest one
        private int currentTest = 0;   //0 is trial, 1 is main
        private Boolean isReadyToStartMainAttempt = true;
        private Boolean mainTestIsAlreadyRunning = false;

        public Test1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            InitializeDescriptionLabel();
        }

        private void InitializeDescriptionLabel()
        {
            test1DescriptionLabel.Text = "Znajdujesz się w fazie szkoleniowej. Po pojawieniu sie zielonego swiatla " +
                "nacisnij jaszybciej gaz, po pojawieniu sie czerwonego hamulec, natomiast gdy pojawi sie zolte swiatlo " +
                "nie naciskaj zadnego przycisku. Proba zostanie wykonana pieciokrotnie. Kliknij przycisk " +
                "START aby rozpoczac probe testowa.";
        }

        private void InitializeMainAttemptLabel()
        {
            test1DescriptionLabel.Text = "Znajdujesz się w testowej. Naciśnij przycisk START aby rozpoczac test.";
        }

        private void startTrial_Click(object sender, EventArgs e)
        {
            if (mainTestIsAlreadyRunning == false)
            {
                changeButtonColor();
                if (currentTest >= 1)
                mainTestIsAlreadyRunning = true;
            }
        }

        private void gas_Click(object sender, EventArgs e)
        {
            if (roundButton3.BackColor == Color.Green)
            {
                roundButton3.BackColor = Color.Black;
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
                if (results.Count >= 10)
                {
                    Form1.globalResults[0] = avg();
                    this.Close();
                }
                else if (isReadyToStartMainAttempt)
                {
                    InitializeMainAttemptLabel();
                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                    roundButton3.BackColor = Color.Black;
                    isReadyToStartMainAttempt = false;
                }
            }
        }

        private long avg()
        {
            long sum = 0;
            foreach (var result in results.Skip(Math.Max(0, results.Count() - 5)))
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
                roundButton3.BackColor = Color.Green;
                time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            addToTotalMeasurements();
        }
    }
}
