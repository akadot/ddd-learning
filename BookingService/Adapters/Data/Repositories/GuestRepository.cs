using Domain;

namespace Data.Repositories;

public class GuestRepository : IGuestRepository
{
    private HotelDbContext _context;

    public GuestRepository(HotelDbContext context)
    {
        _context = context;
    }
    public async Task<long> Create(Guest guest)
    {
        _context.Guests.Add(guest);

        await _context.SaveChangesAsync();

        return guest.Id;

    }

    public Task<Guest> Get(long Id)
    {
        throw new NotImplementedException();
    }
}
