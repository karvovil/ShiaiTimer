using System;

namespace ShiaiTimer
{
    //class for holding the point situation and faults of single match.
    public class Scorecard
    {
        private int whiteIppon;
        private int blueIppon;
        private int whiteWazaAri;
        private int blueWazaAri;
        private int whiteYuko;
        private int blueYuko;
        private int whiteShido;
        private int blueShido;
        private int whiteHansokumake;
        private int blueHansokumake;

        public Scorecard()
        {
            whiteIppon = 0;
            blueIppon = 0;
            whiteWazaAri = 0;
            blueWazaAri = 0;
            whiteYuko = 0;
            blueYuko = 0;
            whiteShido = 0;
            blueShido = 0;
            whiteHansokumake = 0;
            blueHansokumake = 0;
    }

        public void AddWhiteIppon()
        {
            whiteIppon++;
        }
        public void AddBlueIppon()
        {
            blueIppon++;
        }
        //two waza-aris convert to an ippon
        public void AddWhiteWazaAri()
        {
            whiteWazaAri++;
            if(whiteWazaAri == 2)
            {
                AddWhiteIppon();
                whiteWazaAri = 0;
            }
        }
        public void AddBlueWazaAri()
        {
            blueWazaAri++;
            if (blueWazaAri == 2)
            {
                AddBlueIppon();
                blueWazaAri = 0;
            }
        }
        public void AddWhiteYuko()
        {
            whiteYuko++;
        }
        public void AddBlueYuko()
        {
            blueYuko++;
        }
        public void AddWhiteShido()
        {
            whiteShido++;
        }
        public void AddBlueShido()
        {
            blueShido++;
        }
        public void AddWhiteHansokumake()
        {
            whiteHansokumake++;
        }
        public void AddBlueHansokumake()
        {
            blueHansokumake++;
        }
        //returns simple textual represantion of point situation of white player
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
