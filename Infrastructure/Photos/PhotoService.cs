using System;
using Application.Interfaces;
using Application.Profiles.DTOs;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Photos;

public class PhotoService : IPhotoService
{
    public Task<string> DeletePhoto(string publicId)
    {
        throw new NotImplementedException();
    }

    public async Task<PhotoUploadResult> UploadPhoto(IFormFile file)
    {
        throw new NotImplementedException();
        // if(file.Length > 0)
        // {
        //     await using var stream = file.OpenReadStream();

        //     var uploadParams = new ImageUploadParams
        //     {
                
        //     }
        // }
    }
}
