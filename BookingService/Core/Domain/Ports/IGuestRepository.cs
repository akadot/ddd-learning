namespace Domain;

public interface IGuestRepository
{
    Task<Guest> Get(long Id);
    Task<Guest> Post(Guest guest);
}
