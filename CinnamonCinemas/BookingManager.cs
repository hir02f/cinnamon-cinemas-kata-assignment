using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonCinemas
{
    public class BookingManager
    {
        private const int MAX_ALLOWED = 3;

        public List<Booking> SeatingInfo = new()
        {
            new Booking("A1", ""),
            new Booking("A2", ""),
            new Booking("A3", ""),
            new Booking("A4", ""),
            new Booking("A5", ""),
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

        public enum MakeBookingResult 
        {
            OK,
            NO_BOOKING_MADE,
            MAXIMUM_REQUESTED_EXCEEDED,
            NOT_ENOUGH_SEATS_LEFT,
        }

        public MakeBookingResult MakeBooking(int numberOfSeats, string customerName)
        {
            var availableSeats = SeatingInfo.Where(s => !s.SeatHasBeenAllocated()).ToList();

            if (numberOfSeats == 0)
            {
                return MakeBookingResult.NO_BOOKING_MADE;
            }

            if (numberOfSeats > MAX_ALLOWED)
            {
                return MakeBookingResult.MAXIMUM_REQUESTED_EXCEEDED;
            }        

            if (availableSeats.Count() < numberOfSeats)
            {
                return MakeBookingResult.NOT_ENOUGH_SEATS_LEFT;
            }

            for (int i = 0; i < numberOfSeats; i++)
            {
                availableSeats.ElementAt(i).SetCustomerName(customerName);
            }
            return MakeBookingResult.OK;
        }
    }
}
