using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc
{
    public class MovieTicket
    {
        private MovieScreening movieScreening;

        private int rowNr;
        private int seatNr;
        private bool isPremium;

        public MovieTicket(MovieScreening movieScreening, bool isPremium, int rowNr, int seatNr)
        {
            this.movieScreening = movieScreening;
            this.isPremium = isPremium;
            this.rowNr = rowNr;
            this.seatNr = seatNr;
        }

        public bool IsPremium()
        {
            return isPremium;
        }

        public double GetPrice()
        {
            return movieScreening.GetPricePerSeat();
        }

        public override String ToString()
        {
            return movieScreening.ToString() + " - row " + rowNr + ", seat " + seatNr +
                   (isPremium ? " (Premium)" : "");
        }
    }
}
