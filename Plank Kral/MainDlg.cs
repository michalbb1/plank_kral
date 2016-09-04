using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plank_Kral
{
    public partial class MainDlg : Form
    {
        public int iStartingTime = 90000;
        public int iPlankMS;
        bool bPlankRunning = false;
        int iPlankState = -1;
        int iCountDownSeconds = 5;

        LanguageSpeaker[] languages =
        {
            new LanguageSpeakerEn("data\\languages\\en\\"),
            new LanguageSpeakerDe("data\\languages\\de\\")
        };

        LanguageSpeaker lngCurrent;

        private void ChangeLanguage()
        {
            Random rnd = new Random();
            int index = rnd.Next(languages.Length);
            lngCurrent = languages[index];
        }

        public MainDlg()
        {
            InitializeComponent();
            iPlankMS = iStartingTime;
            UpdateTime();
            SoundsQueuePlayer.Start();
            lngCurrent = languages[0];
        }

        private void StopPlank()
        {
            bPlankRunning = false;
            timer_plankingTime.Stop();
            iPlankState = -1;
        }

        private void btn_StartPlank_Click(object sender, EventArgs e)
        {
            if (!bPlankRunning)
            {
                ChangeLanguage();
                iPlankMS = 0;
                bPlankRunning = true;
                iPlankState = 0;
                iCountDownSeconds = 5;
                lngCurrent.SayStart();
                timer_plankingTime.Interval = 1000;
                timer_plankingTime.Start();
                UpdateTime();

                lngCurrent.SayCountdown(iCountDownSeconds);
            }
            else
            {
                StopPlank();
                UpdateTime();
            }
            EnableWindows();
        }

        public void EnableWindows()
        {
            btn_Minus1.Enabled = !bPlankRunning;
            btn_Minus5.Enabled = !bPlankRunning;
            btn_Plus1.Enabled = !bPlankRunning;
            btn_Plus5.Enabled = !bPlankRunning;

            btn_StartPlank.Text = bPlankRunning ? "Stop Plank" : "Start Plank";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.plank2;
        }

        private void timer_plankingTime_Tick(object sender, EventArgs e)
        {
            if (iPlankState == 0)
            {
                iCountDownSeconds -= 1;
                
                if (iCountDownSeconds == 0)
                {
                    lngCurrent.SayGo();
                    iPlankState = 1;
                    timer_plankingTime.Interval = 100;
                }
                else lngCurrent.SayCountdown(iCountDownSeconds);
            }
            else if(iPlankState == 1)
            {
                iPlankMS += 100;

                int remainingTime = iStartingTime - iPlankMS;

                if (iPlankMS == iStartingTime)
                {
                    lngCurrent.SayFinish();
                    StopPlank();
                    EnableWindows();
                }
                else if (remainingTime % 1000 == 0 && remainingTime <= 10000)
                {
                    lngCurrent.SayCountdown(remainingTime / 1000);
                }
                else if (iPlankMS % 5000 == 0)
                {
                    lngCurrent.SayTime(iPlankMS / 1000);
                }
            }
            UpdateTime();
        }

        private string MilliSecondsToString(int milli)
        {
            string sNewString = ((milli / 1000 % 3600) / 60).ToString("D2") + ":" + (milli / 1000 % 60).ToString("D2") + ":" + (milli % 1000).ToString("D3"); // Seconds
            return sNewString;
        }

        private void UpdateTime()
        {
            if(iPlankState == -1)
            {
                lbl_Time.Text = MilliSecondsToString(iStartingTime);
            }
            if (iPlankState == 0)
            {
                lbl_Time.Text = iCountDownSeconds.ToString();
            }
            else if (iPlankState == 1)
            {
                string sNewString = MilliSecondsToString(iPlankMS) + " / " + MilliSecondsToString(iStartingTime);
                lbl_Time.Text = sNewString;
            }
        }

        private void AddToTime(int howMuch)
        {
            if (iStartingTime == 0 && howMuch < 0)
                return;
            iStartingTime += howMuch;
            if (!bPlankRunning)
                iPlankMS = iStartingTime;
            UpdateTime();
        }

        private void btn_Plus5_Click(object sender, EventArgs e)
        {
            AddToTime(5000);
        }

        private void btn_Minus5_Click(object sender, EventArgs e)
        {
            AddToTime(-5000);
        }

        private void btn_Minus1_Click(object sender, EventArgs e)
        {
            AddToTime(-1000);
        }

        private void btn_Plus1_Click(object sender, EventArgs e)
        {
            AddToTime(1000);
        }

        private void MainDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundsQueuePlayer.Stop();
        }
    }
}
