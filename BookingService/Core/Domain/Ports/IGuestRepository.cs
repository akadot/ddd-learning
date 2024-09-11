namespace Domain;

public interface IGuestRepository
{
    Task<Guest> Get(long Id);
    Task<long> Create(Guest guest);
}
