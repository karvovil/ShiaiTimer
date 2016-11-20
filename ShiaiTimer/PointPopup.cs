using System;
using System.Windows.Forms;

namespace ShiaiTimer
{
    //Popup form for selecting point type. 
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
