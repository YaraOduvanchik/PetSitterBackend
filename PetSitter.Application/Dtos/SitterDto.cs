﻿namespace PetSitter.Application.Dtos;

public class SitterDto
{
    public Guid Id { get; init; }
    
    public string Name { get; init; } = string.Empty;
    public string Surname { get; init; } = string.Empty;
    public string Patronymic { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string Street { get; init; } = string.Empty;
    public string Building { get; init; } = string.Empty;
    public string Index { get; init; } = string.Empty;
    public string PhoneNumber { get; init; } = string.Empty;
    public string AnimalCount { get; init; } = string.Empty;
    public string Preferences { get; init; } = string.Empty;
    
    public DateTimeOffset DateOfBirth { get; init; }
    
}