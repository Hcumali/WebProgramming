using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramming.Extensions;
using WebProgramming.Models;

namespace WebProgramming.Controllers
{
    public class HomeController : Controller
    {
        private INewsDal _newsDal;
        public HomeController(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _newsDal.GetListAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddImage(IFormFile image)
        {
            var tolga = await _newsDal.GetAsync(x => x.Id == 1);

            tolga.Image = await image.GetBytes();

            //var result = _newsDal.UpdateAsync(tolga);

            //News news = new News
            //{
            //    Title = "Deneme",
            //    SubTitle = "Deneme",
            //    Description = "Deneme",
            //    Image = image.GetBytes().Result
            //};
            //_newsDal.AddAsync(news);

            return Content("Ok");

        }
    }
}
