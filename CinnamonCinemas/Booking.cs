using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonCinemas
{
    public class Booking
    {
        public string SeatNumber { get; private set; }
        public string CustomerName { get; private set; }

        public Booking(string seatNumber, string customerName)
        {
            SeatNumber = seatNumber;
            CustomerName = customerName;
        }

        public void SetCustomerName(string name)
        {
            CustomerName = name;
        }

        public bool SeatHasBeenAllocated()
        {
            Console.WriteLine(!String.IsNullOrEmpty(CustomerName));
            //Console.WriteLine(CustomerName != "");
            return !String.IsNullOrEmpty(CustomerName);
        }
    }
}
