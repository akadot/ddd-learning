using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasKey(x => x.Id);

        builder.OwnsOne(x => x.Price).Property(y => y.Value);
        builder.OwnsOne(x => x.Price).Property(y => y.Currency);
    }
}
