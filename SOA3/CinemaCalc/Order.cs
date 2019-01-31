using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CinemaCalc
{
    public class Order
    {
        private int orderNr;
        private bool isStudentOrder;

        private List<MovieTicket> tickets;

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
            
            tickets = new List<MovieTicket>();
        }

        public int GetOrderNumber()
        {
            return this.orderNr;
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            tickets.Add(ticket);
        }

        public double CalculatePrice()
        {
            double totalPrice = 0.00;
            double studentDiscountPercentage = 10; // Percentage might change
            double groupDiscountPercentage = 10; // Percentage might change too.
            bool secondTicketFree = false;
            bool groupDiscount = false;

            int ticketNumber = 0;
            double ticketPrice = 0.00;

            foreach (MovieTicket ticket in tickets)
            {
                ticketPrice = ticket.GetPrice();

                // Keeping track of every ticket number to give free tickets on the second tickets.
                ticketNumber++;

                if (isStudentOrder)
                {
                    secondTicketFree = true;
                }

                // Checking the day of the screening, applying free tickets where required
                DayOfWeek dayOfScreening = ticket.GetScreening().GetDateTime().DayOfWeek;
                if (dayOfScreening == DayOfWeek.Friday
                    || dayOfScreening == DayOfWeek.Saturday
                    || dayOfScreening == DayOfWeek.Sunday)
                {

                }
                else
                {
                    secondTicketFree = true;
                }

                if (!isStudentOrder)
                {
                    if (tickets.Count >= 6)
                    {
                        groupDiscount = true;
                    }
                }

                if (ticket.IsPremium())
                {
                    if (isStudentOrder)
                    {
                        ticketPrice += 2;
                    }
                    else
                    {
                        ticketPrice += 3;
                    }
                }

                // Discount calculations
                if (groupDiscount)
                {
                    ticketPrice = ticketPrice * ((100 - groupDiscountPercentage)/100);
                }

                if (isStudentOrder)
                {
                    ticketPrice = ticketPrice * ((100 - studentDiscountPercentage) /100);
                }

                if (!(secondTicketFree && ticketNumber % 2 == 0))
                {
                    totalPrice += ticketPrice;
                }
            }

            return totalPrice;
        }

        public void Export(TicketExportFormat format)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (format == TicketExportFormat.PLAINTEXT)
            {
                using (TextWriter tw = new StreamWriter(path + @"\Order_" + orderNr + ".txt", false))
                {
                    foreach (MovieTicket ticket in tickets)
                    {
                        tw.WriteLine(ticket.ToString());
                        tw.WriteLine();
                    }
                }
            }

            if (format == TicketExportFormat.JSON)
            {
                var json = JsonConvert.SerializeObject(tickets);

                using (TextWriter tw = new StreamWriter(path + @"\Order_" + orderNr + ".json", false))
                {
                    tw.Write(json);
                }

            }
        }
    }
}
