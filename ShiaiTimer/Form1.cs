using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ShiaiTimer
{
    public partial class Form1 : Form
    {

        int matchTime = 5 * 60; //5min matchtime
        int osaekomiTime = 0;
        Scorecard score = new Scorecard();

        public Form1()
        {
            InitializeComponent();
        }



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

        private void whiteOsaekomiTimer_Tick(object sender, EventArgs e)
        {
            osaekomiTime++;
            whiteOsaekomiLabel.Text = osaekomiTime.ToString();
            if (osaekomiTime == 20) { score.AddWhiteIppon(); }
            whitePointLabel.Text = score.WhiteScore();
        }

        private void blueOsaekomiTimer_Tick(object sender, EventArgs e)
        {
            osaekomiTime++;
            blueOsaekomiLabel.Text = osaekomiTime.ToString();
            if (osaekomiTime == 20) { score.AddBlueIppon(); }
            bluePointLabel.Text = score.BlueScore();
        }

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
