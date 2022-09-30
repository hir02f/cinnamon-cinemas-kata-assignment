using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonCinemas
{
    public class BookingManager
    {
        public List<Booking> SeatingInfo = new()
        {
            new Booking("A1", ""),
            new Booking("A2", ""),
            new Booking("A3", ""),
            new Booking("A4", ""),
            new Booking("A5", "")
        };

        public void MakeBooking(int numberOfSeats, string customerName)
        {
            var availableSeats = SeatingInfo.Where(s => !s.SeatHasBeenAllocated()).ToList();
            Console.Write(availableSeats.Count() + "\n");
            for (int i = 0; i < numberOfSeats; i++)
            {
                availableSeats.ElementAt(i).SetCustomerName(customerName);
                Console.WriteLine(availableSeats.ElementAt(i).SeatNumber);
            }
        }
    }
}
