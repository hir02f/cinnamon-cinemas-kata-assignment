namespace CinnamonCinemas.Tests;

public class BookingTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Make_A_Booking_Where_Not_Enough_Seats_Left()
    {
        BookingManager bk = new BookingManager();
        var ex = Assert.Throws<ApplicationException>(() => bk.MakeBooking(16, "Customer1"));
        Assert.That(ex.Message, Is.EqualTo("Not enough seats left!"));
    }

    [Test]
    public void Make_A_Valid_Booking_Of_One_Seat()
    {
        BookingManager bk = new BookingManager();
        bk.MakeBooking(1, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("");
    }
    
    [Test]
    public void Make_A_Valid_Booking_Of_Two_Seats()
    {
        BookingManager bk = new BookingManager();
        bk.MakeBooking(2, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(1).SeatNumber.Should().Be("A2");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("Customer1");
    }
    
    [Test]
    public void Make_A_Valid_Booking_Of_Three_Seats()
    {
        BookingManager bk = new BookingManager();
        bk.MakeBooking(3, "Customer1");
        bk.SeatingInfo.ElementAt(0).SeatNumber.Should().Be("A1");
        bk.SeatingInfo.ElementAt(0).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(1).SeatNumber.Should().Be("A2");
        bk.SeatingInfo.ElementAt(1).CustomerName.Should().Be("Customer1");
        bk.SeatingInfo.ElementAt(2).SeatNumber.Should().Be("A3");
        bk.SeatingInfo.ElementAt(2).CustomerName.Should().Be("Customer1");
    }
}