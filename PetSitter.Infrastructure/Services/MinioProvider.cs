﻿using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Minio;
using Minio.DataModel.Args;
using PetSitter.Application.Abstractions;
using PetSitter.Domain.Common;

namespace PetSitter.Infrastructure.Services;

public class MinioProvider : IMinioProvider
{
    private const string PhotoBucket = "images";

    private readonly IMinioClient _minioClient;
    private readonly ILogger<MinioProvider> _logger;

    public MinioProvider(IMinioClient minioClient, ILogger<MinioProvider> logger)
    {
        _minioClient = minioClient;
        _logger = logger;
    }

    public async Task<Result<string, Error>> UploadPhoto(IFormFile photo, string path)
    {
        try
        {
            var bucketExistArgs = new BucketExistsArgs()
                .WithBucket(PhotoBucket);

            var bucketExist = await _minioClient.BucketExistsAsync(bucketExistArgs);

            if (bucketExist == false)
            {
                var makeBucketArgs = new MakeBucketArgs()
                    .WithBucket(PhotoBucket);

                await _minioClient.MakeBucketAsync(makeBucketArgs);
            }

            await using (var stream = photo.OpenReadStream())
            {
                var putObjectArgs = new PutObjectArgs()
                    .WithBucket(PhotoBucket)
                    .WithStreamData(stream)
                    .WithObjectSize(stream.Length)
                    .WithObject(path);

                var response = await _minioClient.PutObjectAsync(putObjectArgs);

                return response.ObjectName;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);

            return Errors.General.SaveFailure("photo");
        }
    }

    public async Task<Result<bool, Error>> RemovePhoto(string path)
    {
        try
        {
            var bucketExistArgs = new BucketExistsArgs()
                .WithBucket(PhotoBucket);

            var bucketExist = await _minioClient.BucketExistsAsync(bucketExistArgs);

            if (bucketExist == false)
            {
                var makeBucketArgs = new MakeBucketArgs()
                    .WithBucket(PhotoBucket);

                await _minioClient.MakeBucketAsync(makeBucketArgs);
            }

            var removeObjectArgs = new RemoveObjectArgs()
                .WithBucket(PhotoBucket)
                .WithObject(path);

            await _minioClient.RemoveObjectAsync(removeObjectArgs);

            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);

            return Errors.General.SaveFailure("photo");
        }
    }
}