using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebProgramming.Models;

namespace WebProgramming.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewsDbContext _newsDbContext;

        public NewsController(NewsDbContext newsDbContext)
        {
            _newsDbContext  = newsDbContext;
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetNews()
        {
            var news = await _newsDbContext.News.ToListAsync();
            return Ok(news);
        }
        


    }
}
