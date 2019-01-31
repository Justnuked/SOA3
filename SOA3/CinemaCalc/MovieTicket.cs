using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc
{
    public class MovieTicket
    {
        private int rowNr;
        private int seatNr;
        private bool isPremium;

        public MovieTicket()
        {

        }

        public bool IsPremium()
        {
            return isPremium;
        }

        public double GetPrice()
        {
            return 0;
        }

        public override String ToString()
        {
            return "0";
        }
    }
}
