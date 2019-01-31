using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Export()
        {

        }

    }
}
