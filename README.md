# Cinnamon Cinemas Seating Challenge
This project is to develop a program to allocate seats to customers purchasing tickets for a movie theatre.

## Table of Contents

- [About](#about)
- [Getting Started](#getting_started)
- [Solution](#solution)
- [Assumptions/Checks](#assumptions)
- [Contributing](#contributing)

## About
The Cinnamon Cinemas Movie Theatre has 15 seats, arranged in 3 rows of 5, rows are assigned a letter from A to C and seats are assigned a number from 1 to 5.

Customers can request a number of seats between 1 and 3 for a movie. The customer should be allocated the required number of seats from the available seats on the seating plan 
and the seats should be recorded as allocated


## Getting Started
Make a copy of the repository. To use the booking system or to do further tests, you can either enter seats required using the Console (written in Program.cs) or you can, in the CinnamonCinemas.Tests directory, run tests.

## Solution
There is a BookingManager class and a Booking class. 
* The BookingManager holds the seating information and makes bookings.
* Booking has SeatNumber and CustomerName attributes, and checks if a seat has been allocated by checking if CustomerName is null or otherwise.

## Assumptions/Checks

### Seats
The required number of seats are allocated from the available seats starting from seat A1 and filling the auditorium from left to right, front to back. All seats are available at
the start of the program.

### Input
Just a quick check that the number of tickets provided is between 1 and 3 (inclusive). I have added the ability for a customer name to be inputted too, in case in the future, 
one would like to check who has what seats.

### Output
There is no mention of the output format, so the console simply returns the tickets booked, grouped by the customer's name. For example:
```
You have booked the following tickets:
Jasmine Doggrell
Seat: A1
Seat: A2
Seat: A3
Chen Yu Fei
Seat: A4
Seat: A5
Seat: B1
```


## Contributing
Jasmine Doggrell and support from Tech Returners.
