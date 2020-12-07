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
    //5-fold measurement
    //2 trial attempts
    public partial class Test2 : Form
    {
        private readonly int numberOfMainAttempts = 5;
        private readonly int totalNumberOfAttempts = 7;
        private int leftDiode;
        private int bottomDiode;
        private List<PictureBox> pictureBox = new List<PictureBox>();
        private long timeDiff;
        private long time;
        private List<long> results = new List<long>();
        private Boolean isTestRunning = true;
        private Boolean firstTime = true;

        public Test2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            initializePictureBoxList();
            InitializeDescriptionLabel();
        }

        private void InitializeDescriptionLabel()
        {
            test2Label.Text = "Znajdujesz się w fazie szkoleniowej. Po zapaleniu się dwoch czerwonych lampek" +
                "kliknij guzik odpowiadajacy zapalonym guzikom np. jezeli zapalony zostal przysik drugi w osi poziomej" +
                "oraz przycisk drugi w osi pionowej kliknij przycisk A[2][2]. " +
                "Proba zostanie wykonana pieciokrotnie. Kliknij przycisk " +
                "START aby rozpoczac probe testowa.";
        }

        private void InitializeMainAttemptLabel()
        {
            test2Label.Text = "Znajdujesz się w testowej. Naciśnij przycisk START aby rozpoczac test.";
        }

        private void initializePictureBoxList()
        {
            pictureBox.Add(pictureBox1);
            pictureBox.Add(pictureBox2);
            pictureBox.Add(pictureBox3);
            pictureBox.Add(pictureBox4);
            pictureBox.Add(pictureBox5);
            pictureBox.Add(pictureBox6);
            pictureBox.Add(pictureBox7);
            pictureBox.Add(pictureBox8);
        }

        private void startTest2Button_Click(object sender, EventArgs e)
        {
            turnOnDiode();
            startTest2Button.Enabled = false;
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
            Beginning:
                Button button = (Button)sender;
                if (pictureBox[leftDiode].BackColor == Color.Red && pictureBox[bottomDiode].BackColor ==
                    Color.Red && button.Tag.ToString() == (leftDiode.ToString()+bottomDiode.ToString()))
                {
                    pictureBox[leftDiode].BackColor = Color.Black;
                    pictureBox[bottomDiode].BackColor = Color.Black;
                    //Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds() + " " + time);
                    timeDiff = DateTimeOffset.Now.ToUnixTimeMilliseconds() - time;
                    results.Add(timeDiff);
                    addToTotalMeasurements();
                    if (results.Count == (totalNumberOfAttempts - numberOfMainAttempts)) { goto Beginning; }
                    turnOnDiode();
            }
        }

        private void addToTotalMeasurements()
        {
            if (results.Count >= totalNumberOfAttempts-numberOfMainAttempts)
            {
                if (results.Count >= totalNumberOfAttempts)
                {
                    Form1.globalResults[1] = avg();
                    //results.ForEach(Console.WriteLine);
                    isTestRunning = false;
                    this.Close();
                }
                else if (results.Count % (totalNumberOfAttempts-numberOfMainAttempts) == 0 && firstTime)
                {
                    InitializeMainAttemptLabel();
                    foreach (PictureBox pic in pictureBox)
                    {
                        pic.BackColor = Color.Black;
                    }
                    firstTime = false;
                    startTest2Button.Enabled = true;
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isTestRunning)
            {
                e.Cancel = true;
            }
        }
    }
}
