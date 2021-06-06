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
        public static async Task<int> EnsurePopulated(IApplicationBuilder app)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if (!context.News.Any())
                {
                    context.News.AddRange(
                        new News
                        {
                            Title = "Göbekli Tolga Hikayesi",
                            SubTitle = "Şok Şok Şok",
                            Description = "Ayagımın ucunu goremiyorum",
                            Image = new byte[10]
                        }
                    );
                    
                    
                }
                return await context.SaveChangesAsync();
            }


        }
    }
}
