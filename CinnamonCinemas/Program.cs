﻿using CinnamonCinemas;

Console.WriteLine("Booking Manager for Cinnamon Cinemas.........");
BookingManager bk = new();

// INPUT
// =====
bool stillWantTickets = true;
while (stillWantTickets)
{
    try
    {
        Console.WriteLine("Please enter number of tickets: ");
        string numberOfTickets = Console.ReadLine();

        Console.WriteLine("Now enter customer's name: ");
        string customerName = Console.ReadLine();

        bk.MakeBooking(int.Parse(numberOfTickets), customerName);

        Console.WriteLine("Do you still want to book? [Y]es (or enter anything)");
        stillWantTickets = Console.ReadLine() == "Y";
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Booking aborted!");
        return;
    }
}

// OUTPUT
// ======
Console.WriteLine("You have booked the following tickets: ");

var bookings = bk.SeatingInfo.Where(s => s.SeatHasBeenAllocated()).GroupBy(b => b.CustomerName);
foreach (var booking in bookings)
{
    Console.WriteLine(booking.Key);
    foreach (var individualItem in booking)
    {
        Console.WriteLine("Seat: " + individualItem.SeatNumber);
    }
}

