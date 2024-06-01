namespace Domain;

public class Booking : Base
{
    public DateTime PlacedAt { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    private Status Status { get; set; }

    public Status CurrentStatus { get { return this.Status; } }
}
