using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricTest
{
    //5-fold measurement
    //2-trial attempts
    public partial class Test1 : Form
    {
        private readonly int numberOfMainAttempts = 5;
        private readonly int totalNumberOfAttempts = 7;
        private int buttonNumber;
        private long time;
        private long timeDiff;
        private List<long> results = new List<long>(); //each next result of current test is ovewritten on the latest one
        private Boolean firstTime = true;
        private Boolean isTestRunning = true;

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
            startButton.Enabled = false;
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
            if (results.Count >= (totalNumberOfAttempts - numberOfMainAttempts))
            {
                if (results.Count >= totalNumberOfAttempts)
                {
                    Form1.globalResults[0] = avg();
                    isTestRunning = false;
                    Form1.testButtons[0].BackColor = Color.Gray;
                    this.Close();
                }
                else if (results.Count % (totalNumberOfAttempts - numberOfMainAttempts) == 0 && firstTime)
                {
                    InitializeMainAttemptLabel();
                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                    pictureBox3.BackColor = Color.Black;
                    firstTime = false;
                    startButton.Enabled = true;
                }
            }
        }

        private long avg()
        {
            long sum = 0;
            foreach (var result in results.Skip(Math.Max(0, results.Count() - numberOfMainAttempts)))
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
                if (results.Count != (totalNumberOfAttempts-numberOfMainAttempts))
                {
                    changeButtonColor();
                }
            }
            else if (buttonNumber == 2)
            {
                pictureBox3.BackColor = Color.Green;
                time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            addToTotalMeasurements();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isTestRunning)
            {
                e.Cancel = true;
            }
        }
    }
}
