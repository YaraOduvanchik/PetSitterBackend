﻿using PetSitter.Domain.ValueObjects;

namespace Contracts;

public record CreateUserRequest(
    string Name,
    string Surname,
    string Patronymic,
    string PhoneNumber,
    DateTimeOffset DateOfBirth,
    string City, 
    string Street, 
    string Building, 
    string Index);