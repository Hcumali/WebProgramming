using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramming.Extensions;
using WebProgramming.Models;

namespace WebProgramming.Controllers
{
    [Authorize(Roles = "Admin")]
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNews()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNews(NewsModel newsModel)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                News news = new News();
                news.Image = await newsModel.Image.GetBytes();
                news.Title = newsModel.Title;
                news.SubTitle = newsModel.SubTitle;
                news.Description = newsModel.Description;
                await context.News.AddAsync(news);
                await context.SaveChangesAsync();
                return Redirect("/admin/");
            }

        }
        [HttpGet]
        public async Task<IActionResult> UpdateNews(int id)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var news = await context.News.FindAsync(id);
                NewsModel newsModel = new NewsModel();
                newsModel.Id = news.Id;
                newsModel.Title = news.Title;
                newsModel.SubTitle = news.SubTitle;
                newsModel.Description = news.Description;
                return View(newsModel);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateNews(NewsModel newsModel)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var news = context.News.Find(newsModel.Id);
                news.Image = await newsModel.Image.GetBytes();
                news.Title = newsModel.Title;
                news.SubTitle = newsModel.SubTitle;
                news.Description = newsModel.Description;
                context.News.Update(news);
                await context.SaveChangesAsync();
            }
            return Redirect("/admin/");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteNews(int id)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var news = context.News.Find(id);
                context.News.Remove(news);
                await context.SaveChangesAsync();
            }
            return Redirect("/admin/");
        }
    }
}