﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetSitter.Application.Dtos;

namespace PetSitter.Infrastructure.Configurations.Read;

public class PhotoConfiguration : IEntityTypeConfiguration<PhotoDto>
{
    public void Configure(EntityTypeBuilder<PhotoDto> builder)
    {
        builder.ToTable("photos");

        builder.HasKey(p => p.Id);
    }
}