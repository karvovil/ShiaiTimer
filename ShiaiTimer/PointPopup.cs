using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiaiTimer
{
    public partial class PointPopup : Form
    {
        public String pointType;

        public PointPopup()
        {
            InitializeComponent();
        }

        private void ipponButton_Click(object sender, EventArgs e)
        {
            pointType = "Ippon";
        }

        private void wazaAriButton_Click(object sender, EventArgs e)
        {
            pointType = "Waza-Ari";
        }

        private void yukoButton_Click(object sender, EventArgs e)
        {
            pointType = "Yuko";
        }
    }
}
