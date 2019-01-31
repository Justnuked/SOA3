using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CinemaCalc
{
    public class MovieTicket
    {
        [JsonProperty]
        private MovieScreening movieScreening;

        [JsonProperty]
        private int rowNr;
        [JsonProperty]
        private int seatNr;
        [JsonProperty]
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

        public MovieScreening GetScreening()
        {
            return this.movieScreening;
        }

        public override String ToString()
        {
            return movieScreening.ToString() + " - row " + rowNr + ", seat " + seatNr +
                   (isPremium ? " (Premium)" : "");
        }
    }
}
