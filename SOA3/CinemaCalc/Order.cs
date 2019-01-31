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
            return 0;
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
