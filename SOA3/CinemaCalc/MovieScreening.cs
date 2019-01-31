using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc
{
    public class MovieScreening
    {
        private DateTime dateAndTime;
        private double pricePerSeat;

        public MovieScreening()
        {

        }

        public double GetPricePerSeat()
        {
            return this.pricePerSeat;
        }

        public override string ToString()
        {
            return "0";
        }
    }
}
