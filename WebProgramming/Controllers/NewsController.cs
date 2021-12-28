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
        private readonly NewsDbContext _newsDbContext;

        public NewsController(NewsDbContext newsDbContext)
        {
            _newsDbContext = newsDbContext;
        }
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

            News news = new News();
            news.Image = await newsModel.Image.GetBytes();
            news.Title = newsModel.Title;
            news.SubTitle = newsModel.SubTitle;
            news.Description = newsModel.Description;
            await _newsDbContext.News.AddAsync(news);
            await _newsDbContext.SaveChangesAsync();
            return Redirect("/admin/");


        }
        [HttpGet]
        public async Task<IActionResult> UpdateNews(int id)
        {

            var news = await _newsDbContext.News.FindAsync(id);
            NewsModel newsModel = new NewsModel();
            newsModel.Id = news.Id;
            newsModel.Title = news.Title;
            newsModel.SubTitle = news.SubTitle;
            newsModel.Description = news.Description;
            return View(newsModel);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateNews(NewsModel newsModel)
        {

            var news = _newsDbContext.News.Find(newsModel.Id);
            news.Image = await newsModel.Image.GetBytes();
            news.Title = newsModel.Title;
            news.SubTitle = newsModel.SubTitle;
            news.Description = newsModel.Description;
            _newsDbContext.News.Update(news);
            await _newsDbContext.SaveChangesAsync();

            return Redirect("/admin/");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteNews(int id)
        {

            var news = _newsDbContext.News.Find(id);
            _newsDbContext.News.Remove(news);
            await _newsDbContext.SaveChangesAsync();

            return Redirect("/admin/");
        }
    }
}