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

        int matchTimer = 5 * 60; //5min matchtime
        Scorecard score = new Scorecard();

        public Form1()
        {
            InitializeComponent();
        }



        private void whitePointButton_Click(object sender, EventArgs e)
        {
            score.AddWhiteIppon();
            whitePointLabel.Text = score.WhiteScore();
        }

        private void bluePointButton_Click(object sender, EventArgs e)
        {
            score.AddBlueIppon();
            bluePointLabel.Text = score.blueIppon.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            matchTimer--;
            matchTimeLabel.Text = (matchTimer/60).ToString() + " : " + (matchTimer % 60).ToString();
        }

        private void startTimeButton_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
