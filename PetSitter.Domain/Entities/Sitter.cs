﻿using PetSitter.Domain.ValueObjects;

namespace PetSitter.Domain.Entities;

public class Sitter
{
    private Sitter()
    {
        
    }

    public Sitter(
        Guid id,
        string name,
        string surname,
        string patronymic,
        Address address,
        PhoneNumber phoneNumber,
        DateTimeOffset dateOfBirth,
        string animalCount,
        string preferences)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
        Address = address;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        AnimalCount = animalCount;
        Preferences = preferences;
    }

    public Guid Id { get; private set;  }
    
    public string Name { get; private set; }
    
    public string Surname { get; private set; }

    public string Patronymic { get; private set; }

    public Address Address { get; private set; }

    public PhoneNumber PhoneNumber {  get; private set; }

    public DateTimeOffset DateOfBirth { get; private set; }

    public string AnimalCount { get; private set; }

    public string Preferences { get; private set; }
}