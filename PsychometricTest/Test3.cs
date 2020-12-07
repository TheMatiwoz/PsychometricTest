using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychometricTest
{
    //5-fold measurement
    //2-trial attempts
    public partial class Test3 : Form
    {
        private readonly int numberOfMainAttempts = 5;
        private readonly int totalNumberOfAttempts = 7;
        private Stream soundFileName;
        private System.Media.SoundPlayer soundPlayer;
        private List<long> results = new List<long>();
        private long time;
        private Boolean isTestRunning = true;
        private Boolean firstTime = true;

        public Test3()
        {
            soundFileName = Properties.Resources.alarmSound;
            Console.WriteLine("Sound file name" + soundFileName);
            soundPlayer = new System.Media.SoundPlayer(soundFileName);

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            InitializeDescriptionLabel();
        }

        private void InitializeDescriptionLabel()
        {
            test3Label.Text = "Znajdujesz się w fazie szkoleniowej. Po uslyszeniu dzwieku kliknij jak najszybciej w przycisk."+
                "Proba zostanie wykonana pieciokrotnie. Kliknij przycisk " +
                "START aby rozpoczac probe testowa.";
        }

        private void InitializeMainAttemptLabel()
        {
            test3Label.Text = "Znajdujesz się w testowej. Naciśnij przycisk START aby rozpoczac test.";
        }

        private void onStart_Click(object sender, EventArgs e)
        {
            playMusic();
            startButtonTest3.Enabled = false;
        }

        private async void playMusic()
        {
            this.button1.Enabled = false;
            await Task.Delay(new Random().Next(1000, 2500));     //delay of changing colors
            this.button1.Enabled = true;
            soundPlayer.Play();
            time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        private void stopMusic()
        {
            soundPlayer.Stop();
            long timeDiff = time - DateTimeOffset.Now.ToUnixTimeMilliseconds();
            results.Add(timeDiff);
        }

        private void alarmButton_Clicked(object sender, EventArgs e)
        {
            stopMusic();
            addToTotalMeasurements();

            if (results.Count != (totalNumberOfAttempts-numberOfMainAttempts) && results.Count != totalNumberOfAttempts)
            {
                playMusic();
            }
        }

        private void addToTotalMeasurements()
        {
            if (results.Count >= totalNumberOfAttempts - numberOfMainAttempts)
            {
                if (results.Count >= totalNumberOfAttempts)
                {
                    Form1.globalResults[2] = avg();
                    //results.ForEach(Console.WriteLine);
                    isTestRunning = false;
                    soundPlayer.Stop();
                    this.Close();
                }
                else if (results.Count % (totalNumberOfAttempts - numberOfMainAttempts) == 0 && firstTime)
                {
                    InitializeMainAttemptLabel();
                    soundPlayer.Stop();
                    firstTime = false;
                    button1.Enabled = false;
                    startButtonTest3.Enabled = true;
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

        protected override void OnFormClosing(FormClosingEventArgs e)  //event when form closing
        {
            if (isTestRunning)
            {
                e.Cancel = true;
            }
        }
    }
}
