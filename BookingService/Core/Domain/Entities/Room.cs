using Domain.ValueObjects;

namespace Domain;

public class Room : Base
{
    public int Number { get; set; }
    public int Level { get; set; }
    public bool InMaintence { get; set; }

    public Price Price {get;set;} = null!;

    public bool IsAvailable
    {
        get
        {
            if (this.InMaintence || this.HasGuest)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public bool HasGuest
    {
        //verifica se existem bookings abertos
        get { return true; }
    }
}
