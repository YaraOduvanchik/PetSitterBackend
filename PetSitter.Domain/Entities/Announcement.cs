﻿namespace PetSitter.Domain.Entities;

public class Announcement
{
    private Announcement()
    {
        
    }
    
    public Announcement(
        User user,
        Animal animal,
        string receipt,
        DateTimeOffset transferDate,
        DateTimeOffset completionDate,
        string description,
        decimal price)
    {
        User = user;
        Animal = animal;
        Receipt = receipt;
        TransferDate = transferDate;
        CompletionDate = completionDate;
        Description = description;
        Price = price;
    }

    public Guid Id { get; private set; }
    
    public User User { get; private set; }

    public Animal Animal { get; private set; }

    public string Receipt { get; private set; }

    public DateTimeOffset TransferDate { get; private set; }

    public DateTimeOffset CompletionDate { get; private set; }

    public string Description { get; private set; }

    public decimal Price { get; private set; }
}