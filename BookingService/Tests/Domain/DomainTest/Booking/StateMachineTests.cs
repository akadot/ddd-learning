using Domain;

namespace DomainTest.Bookings;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldAlwaysStartWithCreatedStatus()
    {
        Booking booking = new Booking();

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Created));
    }

    [Test]
    public void ShouldSetStatusToPaidWhenPayingForABookingWithCreatedStatus()
    {
        Booking booking = new Booking();
        booking.ChangeState(Actions.Pay);
        
        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Paid));
    }

    [Test]
    public void ShouldSetStatusToCancelWhenCancelingABookingWithCreatedStatus()
    {
        Booking booking = new Booking();
        booking.ChangeState(Actions.Cancel);

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Canceled));
    }

    [Test]
    public void ShouldSetStatusToFinishWhenFinishingAPaidBooking()
    {
        Booking booking = new Booking();
        
        booking.ChangeState(Actions.Pay);
        booking.ChangeState(Actions.Finish);

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Finished));
    }

    [Test]
    public void ShouldSetStatusToRefoundedWhenRefundAPaidBooking()
    {
        Booking booking = new Booking();

        booking.ChangeState(Actions.Pay);
        booking.ChangeState(Actions.Refund);

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Refounded));
    }

    [Test]
    public void ShouldSetStatusToCreatedWhenReopenACanceledBooking()
    {
        Booking booking = new Booking();

        booking.ChangeState(Actions.Cancel);
        booking.ChangeState(Actions.Reopen);

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Created));
    }

    [Test]
    public void ShouldNotChangeStatusWhenRefundingABookingWithCreatedSatus()
    {
        Booking booking = new Booking();

        booking.ChangeState(Actions.Refund); //Ação inválida, apenas retorna o staus inicial do booking

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Created));
    }

    [Test]
    public void ShouldNotCHangeStatusWhenRefundingABookingWithFinishedSatus()
    {
        Booking booking = new Booking();

        booking.ChangeState(Actions.Pay); 
        booking.ChangeState(Actions.Finish); 
        booking.ChangeState(Actions.Refund); //Ação inválida, apenas retorna o staus de encerrado

        Assert.That(booking.CurrentStatus, Is.EqualTo(Status.Finished));
    }
}