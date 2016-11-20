using System;
using System.Windows.Forms;

namespace ShiaiTimer
{
    public partial class Form1 : Form
    {

        int matchTime; 
        int osaekomiTime;  
        Scorecard score;

        public Form1()
        {
            InitializeComponent();
            matchTime = 5 * 60; //5min matchtime
            osaekomiTime = 0; 
            score = new Scorecard();
        }


        //opens popup, adds selected point to scorecard, updates point label and disposes the popup.
        private void whitePointButton_Click(object sender, EventArgs e)
        {
            
            PointPopup popup = new PointPopup();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                if (popup.pointType == "Ippon") { score.AddWhiteIppon(); }
                else if (popup.pointType == "Waza-Ari") { score.AddWhiteWazaAri(); }
                else if (popup.pointType == "Yuko") { score.AddWhiteYuko(); }
            }

            whitePointLabel.Text = score.WhiteScore();
            popup.Dispose();
        }

        private void bluePointButton_Click(object sender, EventArgs e)
        {
            PointPopup popup = new PointPopup();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                if (popup.pointType == "Ippon") { score.AddBlueIppon(); }
                else if (popup.pointType == "Waza-Ari") { score.AddBlueWazaAri(); }
                else if (popup.pointType == "Yuko") { score.AddBlueYuko(); }
            }

            bluePointLabel.Text = score.BlueScore();
            popup.Dispose();
        }

        private void matchTimer_Tick(object sender, EventArgs e)
        {
            matchTime--;
            matchTimeLabel.Text = (matchTime/60).ToString() + " : " + (matchTime % 60).ToString();
        }

        private void startTimeButton_Click(object sender, EventArgs e)
        {
            if(matchTimer.Enabled)
            {
                matchTimer.Stop();
                startTimeButton.Text = "Start";
            }
            else
            {
                matchTimer.Start();
                startTimeButton.Text = "Stop";
            }
        }
        //updates osaekomi timer. If Osaekomi lasts 20 secs, adds ippon to scorecard
        private void whiteOsaekomiTimer_Tick(object sender, EventArgs e)
        {
            osaekomiTime++;
            whiteOsaekomiLabel.Text = osaekomiTime.ToString();
            if (osaekomiTime == 20)
            {
                score.AddWhiteIppon();
                whitePointLabel.Text = score.WhiteScore();
            }

            
        }

        private void blueOsaekomiTimer_Tick(object sender, EventArgs e)
        {
            osaekomiTime++;
            blueOsaekomiLabel.Text = osaekomiTime.ToString();
            if (osaekomiTime == 20)
            {
                score.AddBlueIppon();
                bluePointLabel.Text = score.BlueScore();
            }
            
        }
        //Stops/starts osaekomi timer and updates points according to elapsed osaekomi time
        private void whiteOsaekomiButton_Click(object sender, EventArgs e)
        {
            if (whiteOsaekomiTimer.Enabled)
            {
                whiteOsaekomiTimer.Stop();
                if (osaekomiTime >= 15) { score.AddWhiteWazaAri(); }
                else if(osaekomiTime >= 10) { score.AddWhiteYuko(); }
                osaekomiTime = 0;
                whitePointLabel.Text = score.WhiteScore();
            }
            else
            {
                osaekomiTime = 0;
                whiteOsaekomiLabel.Text = osaekomiTime.ToString();
                blueOsaekomiTimer.Stop();
                whiteOsaekomiTimer.Start();
            }
        }

        private void blueOsaekomiButton_Click(object sender, EventArgs e)
        {
            if (blueOsaekomiTimer.Enabled)
            {
                blueOsaekomiTimer.Stop();
                if (osaekomiTime >= 15) { score.AddBlueWazaAri(); }
                else if (osaekomiTime >= 10) { score.AddBlueYuko(); }
                osaekomiTime = 0;
                bluePointLabel.Text = score.BlueScore();
            }
            else
            {
                osaekomiTime = 0;
                blueOsaekomiLabel.Text = osaekomiTime.ToString();
                whiteOsaekomiTimer.Stop();
                blueOsaekomiTimer.Start();     
            }
        }


    }
}
