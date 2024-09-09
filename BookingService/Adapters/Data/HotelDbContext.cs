using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data;
public class HotelDbContext(DbContextOptions<HotelDbContext> options) : DbContext(options)
{
    public virtual DbSet<Guest> Guests {get; set;}

    public virtual DbSet<Booking> Bookings {get;set;}
}
