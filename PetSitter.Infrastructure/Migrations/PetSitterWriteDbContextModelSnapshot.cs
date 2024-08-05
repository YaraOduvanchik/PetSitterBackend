﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PetSitter.Infrastructure.DbContexts;

#nullable disable

namespace PetSitter.Infrastructure.Migrations
{
    [DbContext(typeof(PetSitterWriteDbContext))]
    partial class PetSitterWriteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PetSitter.Domain.Entities.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Birthday")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birthday");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("breed");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("TypeKind")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type_kind");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<Guid?>("UserId1")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id1");

                    b.Property<float>("Weight")
                        .HasColumnType("real")
                        .HasColumnName("weight");

                    b.HasKey("Id")
                        .HasName("pk_animals");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_animals_user_id");

                    b.HasIndex("UserId1")
                        .HasDatabaseName("ix_animals_user_id1");

                    b.ToTable("animals", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uuid")
                        .HasColumnName("animal_id");

                    b.Property<DateTimeOffset>("CompletionDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("completion_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<string>("Receipt")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("receipt");

                    b.Property<DateTimeOffset>("TransferDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("transfer_date");

                    b.HasKey("Id")
                        .HasName("pk_announcements");

                    b.HasIndex("AnimalId")
                        .HasDatabaseName("ix_announcements_animal_id");

                    b.ToTable("announcements", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Disease", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AnimalId")
                        .HasColumnType("uuid")
                        .HasColumnName("animal_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Symptom")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("symptom");

                    b.HasKey("Id")
                        .HasName("pk_diseases");

                    b.HasIndex("AnimalId")
                        .HasDatabaseName("ix_diseases_animal_id");

                    b.ToTable("diseases", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AnimalId")
                        .HasColumnType("uuid")
                        .HasColumnName("animal_id");

                    b.Property<bool>("IsMain")
                        .HasColumnType("boolean")
                        .HasColumnName("is_main");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("path");

                    b.HasKey("Id")
                        .HasName("pk_photos");

                    b.HasIndex("AnimalId")
                        .HasDatabaseName("ix_photos_animal_id");

                    b.ToTable("photos", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Sitter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("AnimalCount")
                        .HasColumnType("integer")
                        .HasColumnName("animal_count");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<string>("Preferences")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("preferences");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.ComplexProperty<Dictionary<string, object>>("Address", "PetSitter.Domain.Entities.Sitter.Address#Address", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Building")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("building");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("city");

                            b1.Property<string>("Index")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("index");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("street");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("PhoneNumber", "PetSitter.Domain.Entities.Sitter.PhoneNumber#PhoneNumber", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("phone_number");
                        });

                    b.HasKey("Id")
                        .HasName("pk_sitters");

                    b.ToTable("sitters", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.ComplexProperty<Dictionary<string, object>>("Address", "PetSitter.Domain.Entities.User.Address#Address", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Building")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("building");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("city");

                            b1.Property<string>("Index")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("index");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("street");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("PhoneNumber", "PetSitter.Domain.Entities.User.PhoneNumber#PhoneNumber", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("phone_number");
                        });

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Vaccination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AnimalId")
                        .HasColumnType("uuid")
                        .HasColumnName("animal_id");

                    b.Property<int>("DurationDay")
                        .HasColumnType("integer")
                        .HasColumnName("duration_day");

                    b.Property<bool>("IsTimeLimit")
                        .HasColumnType("boolean")
                        .HasColumnName("is_time_limit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_vaccinations");

                    b.HasIndex("AnimalId")
                        .HasDatabaseName("ix_vaccinations_animal_id");

                    b.ToTable("vaccinations", (string)null);
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Animal", b =>
                {
                    b.HasOne("PetSitter.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_animals_users_user_id");

                    b.HasOne("PetSitter.Domain.Entities.User", null)
                        .WithMany("Animals")
                        .HasForeignKey("UserId1")
                        .HasConstraintName("fk_animals_users_user_id1");
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Announcement", b =>
                {
                    b.HasOne("PetSitter.Domain.Entities.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_announcements_animals_animal_id");
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Disease", b =>
                {
                    b.HasOne("PetSitter.Domain.Entities.Animal", null)
                        .WithMany("Diseases")
                        .HasForeignKey("AnimalId")
                        .HasConstraintName("fk_diseases_animals_animal_id");
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Photo", b =>
                {
                    b.HasOne("PetSitter.Domain.Entities.Animal", null)
                        .WithMany("Photos")
                        .HasForeignKey("AnimalId")
                        .HasConstraintName("fk_photos_animals_animal_id");
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Vaccination", b =>
                {
                    b.HasOne("PetSitter.Domain.Entities.Animal", null)
                        .WithMany("Vaccinations")
                        .HasForeignKey("AnimalId")
                        .HasConstraintName("fk_vaccinations_animals_animal_id");
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.Animal", b =>
                {
                    b.Navigation("Diseases");

                    b.Navigation("Photos");

                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("PetSitter.Domain.Entities.User", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
