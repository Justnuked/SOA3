using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CinemaCalc
{
    public class MovieScreening
    {
        [JsonProperty]
        private Movie movie;

        [JsonProperty]
        private DateTime dateAndTime;

        [JsonProperty]
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

        public DateTime GetDateTime()
        {
            return dateAndTime;
        }

        public override string ToString()
        {
            return movie.ToString() + " - " + dateAndTime;
        }
    }
}
