﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Data.Configurations;

namespace Data;
public class HotelDbContext(DbContextOptions<HotelDbContext> options) : DbContext(options)
{
    public virtual DbSet<Guest> Guests {get; set;}

    public virtual DbSet<Room> Rooms {get; set;}
    public virtual DbSet<Booking> Bookings {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GuestConfiguration());
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
    }
}
