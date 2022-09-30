namespace CinnamonCinemas.Tests;

public class BookingTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Make_An_Invalid_Booking_Where_Not_Enough_Seats_Left()
    {
        BookingManager bk = new ();
        bk.MakeBooking(3, "Customer1");
        bk.MakeBooking(3, "Customer2");
        bk.MakeBooking(3, "Customer3");
        bk.MakeBooking(3, "Customer4");
        bk.MakeBooking(3, "Customer5");
        var ex = Assert.Throws<ApplicationException>(() => bk.MakeBooking(2, "Customer6"));
        Assert.That(ex.Message, Is.EqualTo("Not enough seats left!"));
    }

    [Test]
    public void Make_An_Invalid_Booking_Requesting_Zero_Seat()
    {
        BookingManager bk = new();
        var ex = Assert.Throws<ApplicationException>(() => bk.MakeBooking(0, "Customer1"));
        Assert.That(ex.Message, Is.EqualTo("You have made NO booking....?"));
    }

    [Test]
    public void Make_An_Invalid_Booking_Requsting_Four_Seats()
    {
        BookingManager bk = new();
        var ex = Assert.Throws<ApplicationException>(() => bk.MakeBooking(4, "Customer1"));
        Assert.That(ex.Message, Is.EqualTo("You cannot book more than 3 seats at once!"));
    }

    [Test]
    public void Make_A_Valid_Booking_Of_One_Seat()
    {
        BookingManager bk = new ();
        bk.MakeBooking(1, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("");
    }
    
    [Test]
    public void Make_A_Valid_Booking_Of_Two_Seats()
    {
        BookingManager bk = new ();
        bk.MakeBooking(2, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(1).SeatNumber.Should().Be("A2");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("Customer1");
    }
    
    [Test]
    public void Make_A_Valid_Booking_Of_Three_Seats()
    {
        BookingManager bk = new ();
        bk.MakeBooking(3, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(1).SeatNumber.Should().Be("A2");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(2).SeatNumber.Should().Be("A3");
        bk.SeatingInfo.ElementAt(2).CustomerName.Should().Be("Customer1");
    }

    [Test]
    public void Make_A_Valid_Booking_Of_One_Seat_Then_Three_Seats()
    {
        BookingManager bk = new();
        bk.MakeBooking(1, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.MakeBooking(3, "Customer2");
        bk.SeatingInfo.ElementAt(1).SeatNumber.Should().Be("A2");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("Customer2");
        bk.SeatingInfo.ElementAt(2).SeatNumber.Should().Be("A3");
        bk.SeatingInfo.ElementAt(2).CustomerName.Should().Be("Customer2");
        bk.SeatingInfo.ElementAt(3).SeatNumber.Should().Be("A4");
        bk.SeatingInfo.ElementAt(3).CustomerName.Should().Be("Customer2");
    }
}