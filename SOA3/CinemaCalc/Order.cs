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

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
        }

        public int GetOrderNumber()
        {
            return this.orderNr;
        }

        public void AddSeatReservation()
        {

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
