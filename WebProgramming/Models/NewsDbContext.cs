using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public class NewsDbContext : IdentityDbContext<IdentityUser>
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) :base(options){ }
        public DbSet<News> News { get; set; }
    }
}
