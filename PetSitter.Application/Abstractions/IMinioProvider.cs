﻿using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Http;
using PetSitter.Domain.Common;

namespace PetSitter.Application.Abstractions;

public interface IMinioProvider
{
    Task<Result<string, Error>> UploadPhoto(IFormFile photo, Guid photoId);
}