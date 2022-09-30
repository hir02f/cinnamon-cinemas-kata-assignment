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
            new Booking("A1", ""),
            new Booking("B1", ""),
            new Booking("B2", ""),
            new Booking("B3", ""),
            new Booking("B4", ""),
            new Booking("B5", ""),
            new Booking("C1", ""),
            new Booking("C2", ""),
            new Booking("C3", ""),
            new Booking("C4", ""),
            new Booking("C5", "")        
        };

        public void MakeBooking(int numberOfSeats, string customerName)
        {
            var availableSeats = SeatingInfo.Where(s => !s.SeatHasBeenAllocated()).ToList();
            //Console.Write(availableSeats.Count() + "\n");

            if (availableSeats.Count() < numberOfSeats)
            {
                throw new ApplicationException("Not enough seats left!");
            }

            for (int i = 0; i < numberOfSeats; i++)
            {
                availableSeats.ElementAt(i).SetCustomerName(customerName);
                Console.WriteLine(availableSeats.ElementAt(i).SeatNumber);
            }
        }
    }
}
