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
    public partial class Test3 : Form
    {
        private readonly int numberOfMeasurements = 5;
        private Stream soundFileName;
        private System.Media.SoundPlayer soundPlayer;
        private List<long> results = new List<long>();
        private long time;

        public Test3()
        {
            soundFileName = Properties.Resources.alarmSound;
            Console.WriteLine("Sound file name" + soundFileName);
            soundPlayer = new System.Media.SoundPlayer(soundFileName);

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button

            playMusic();
        }

        private async void playMusic()
        {
            await Task.Delay(new Random().Next(1000, 2500));     //delay of changing colors
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
        }

        private void addToTotalMeasurements()
        {
            if (results.Count >= numberOfMeasurements)
            {
                Form1.globalResults[2] = avg();
                this.Close();
            }
            else
            {
                playMusic();
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

        protected override void OnFormClosing(FormClosingEventArgs e)  //event when form closing
        {
            base.OnFormClosing(e);
            soundPlayer.Stop();
        }
    }
}
