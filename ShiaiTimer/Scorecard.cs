using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiaiTimer
{
    public class Scorecard
    {
        public int whiteIppon;
        public int blueIppon;
        public int whiteWazaAri;
        public int blueWazaAri;
        public int whiteYuko;
        public int blueYuko;

        public Scorecard()
        {
            whiteIppon = 0;
            blueIppon = 0;
            whiteWazaAri = 0;
            blueWazaAri = 0;
            whiteYuko = 0;
            blueYuko = 0;
        }

        public void AddWhiteIppon()
        {
            whiteIppon++;
        }
        public void AddBlueIppon()
        {
            blueIppon++;
        }
        public void AddWhiteWazaAri()
        {
            whiteWazaAri++;
        }
        public void AddBlueWazaAri()
        {
            blueWazaAri++;
        }
        public void AddWhiteYuko()
        {
            whiteIppon++;
        }
        public void AddBlueYuko()
        {
            blueIppon++;
        }

        public string WhiteScore()
        {
            String whitescore = "";
            whitescore = whiteIppon.ToString() + " " + whiteWazaAri.ToString() + " " + whiteYuko.ToString() ;
            return whitescore;
        }
        public string BlueScore()
        {
            String bluescore = "";
            bluescore = blueIppon.ToString() + " " + blueWazaAri.ToString() + " " + blueYuko.ToString();
            return bluescore;
        }
    }
}
