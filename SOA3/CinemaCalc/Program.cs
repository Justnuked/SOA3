using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("OwO");

            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Now, 10);

            Order o = new Order(1, false);

            MovieTicket ticket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket ticket2 = new MovieTicket(movieScreening, false, 2, 1);
            MovieTicket ticket3 = new MovieTicket(movieScreening, false, 3, 1);
            MovieTicket ticket4 = new MovieTicket(movieScreening, false, 4, 1);

            o.AddSeatReservation(ticket1);
            o.AddSeatReservation(ticket2);
            o.AddSeatReservation(ticket3);
            o.AddSeatReservation(ticket4);

            o.Export(TicketExportFormat.JSON);
            Console.WriteLine("Exporting. . .");

            Console.ReadKey();
        }
    }
}
