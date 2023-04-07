﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategorysController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        [HttpGet]
        public JsonResult Get()
        {
            var categorys = db.Categories.ToList();

            return new JsonResult(categorys);
        }

        [HttpPost]
        public JsonResult Post(Category newCategory)
        {
            db.Categories.Add(newCategory);
            db.SaveChanges();

            return new JsonResult(newCategory);
        }

    }
}
