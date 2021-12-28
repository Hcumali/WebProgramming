using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public static class SeedData
    {
        public static async Task<int> EnsurePopulated(this IApplicationBuilder app)
        {
            var newsDbContext = app.ApplicationServices.GetService<NewsDbContext>();

            if (newsDbContext.Database.GetPendingMigrations().Any())
            {
                newsDbContext.Database.Migrate();
                newsDbContext.Database.EnsureCreated();
            }
            if (!newsDbContext.News.Any())
            {
                newsDbContext.News.AddRange(
                        new News
                        {
                            Title = "Göbekli Tolga Hikayesi",
                            SubTitle = "Şok Şok Şok",
                            Description = "Ayagımın ucunu goremiyorum",
                            Image = new byte[10]
                        }
                    );
                newsDbContext.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole
                {
                    Id = new Guid().ToString(),
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = "Admin"
                });
            }
            return await newsDbContext.SaveChangesAsync();



        }
    }
}
