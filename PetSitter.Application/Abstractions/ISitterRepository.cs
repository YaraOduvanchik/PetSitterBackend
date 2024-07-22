﻿using CSharpFunctionalExtensions;
using PetSitter.Domain.Common;
using PetSitter.Domain.Entities;

namespace PetSitter.Application.Abstractions;

public interface ISitterRepository
{
    Task<Result<Guid, Error>> Add(Sitter sitter, CancellationToken ct);
    Task<IReadOnlyList<Sitter>> Get(CancellationToken ct);
}