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


        public Movie(string title)
        {
            this.title = title;
        }

        public void AddScreening(MovieScreening screening)
        {

        }

        public override string ToString()
        {
            return "0";
        }
    }
}
