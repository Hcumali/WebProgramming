using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public class EfNewsDal : EfEntityRepositoryBase<News>,INewsDal
    {
        public EfNewsDal(NewsDbContext newsDbContext) : base(newsDbContext)
        {
        }
    }
}
