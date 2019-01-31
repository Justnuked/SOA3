using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc
{
    public class Movie
    {
        private string title;
        private List<MovieScreening> screenings;

        public Movie(string title)
        {
            this.title = title;
            screenings = new List<MovieScreening>();
        }

        public void AddScreening(MovieScreening screening)
        {
            screenings.Add(screening);
        }

        public override string ToString()
        {
            return "0";
        }
    }
}
