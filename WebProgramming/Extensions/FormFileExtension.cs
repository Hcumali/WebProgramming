using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace WebProgramming.Extensions
{
    public static class FormFileExtension
    {

        public static async Task<byte[]> GetBytes(this IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                if (formFile != null)
                {
                    await formFile.CopyToAsync(memoryStream);
                    return memoryStream.ToArray();
                }
                return null;
            }
        }
        

    }
}
