using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;

public class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.HasKey(x => x.Id);

        //Setting columns configuration from Value Object
        builder.OwnsOne(x => x.DocumentId).Property(y => y.IdNumber);
        builder.OwnsOne(x => x.DocumentId).Property(y => y.DocumentType);
    }
}
