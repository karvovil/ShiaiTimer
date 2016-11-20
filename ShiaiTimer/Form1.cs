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
        int whitepoints = 0;
        int bluepoints = 0;
        int matchTimer = 5 * 60; //5min

        public Form1()
        {
            InitializeComponent();
        }



        private void whitePointButton_Click(object sender, EventArgs e)
        {
            whitepoints++;
            whitePointLabel.Text = whitepoints.ToString();
        }

        private void bluePointButton_Click(object sender, EventArgs e)
        {
            bluepoints++;
            bluePointLabel.Text = bluepoints.ToString();
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
