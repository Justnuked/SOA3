using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc
{
    public class MovieScreening
    {
        private Movie movie;
        private DateTime dateAndTime;
        private double pricePerSeat;

        public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
        {
            this.movie = movie;
            movie.AddScreening(this);

            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
        }

        public double GetPricePerSeat()
        {
            return this.pricePerSeat;
        }

        public override string ToString()
        {
            return movie.ToString() + " - " + dateAndTime;
        }
    }
}
