﻿namespace PetSitter.Infrastructure.Options;

public class MinioOptions
{
    public const string Minio = nameof(Minio);

    public string Endpoint { get; init; } = string.Empty;

    public string AccsessKey { get; init; } = string.Empty;

    public string SecretKey { get; init; } = string.Empty;
}