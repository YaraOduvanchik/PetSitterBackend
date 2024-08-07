﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetSitter.Domain.Entities;

namespace PetSitter.Infrastructure.Configurations.Write;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .IsRequired();

        builder.Property(s => s.Surname)
            .IsRequired();

        builder.Property(s => s.Patronymic)
            .IsRequired();

        builder.ComplexProperty(s => s.PhoneNumber, b =>
        {
            b.Property(a => a.Number)
                .IsRequired()
                .HasColumnName("phone_number");
        });

        builder.Property(s => s.DateOfBirth)
            .IsRequired();

        builder.ComplexProperty(s => s.Address, b =>
        {
            b.Property(a => a.City)
                .IsRequired()
                .HasColumnName("city");

            b.Property(a => a.Building)
                .IsRequired()
                .HasColumnName("building");

            b.Property(a => a.Street)
                .IsRequired()
                .HasColumnName("street");

            b.Property(a => a.Index)
                .IsRequired()
                .HasColumnName("index");
        });
    }
}