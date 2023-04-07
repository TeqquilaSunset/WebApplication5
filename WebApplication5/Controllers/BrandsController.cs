using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication5;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandsController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        [HttpGet]
        public JsonResult Get()
        {
            var brands = db.Brands.ToList();
            return new JsonResult(brands);
        }

        [HttpPost]
        public JsonResult Post(Brand newBrand)
        {
            if (newBrand == null)
            {
                return new JsonResult(BadRequest());
            }

            db.Brands.Add(newBrand);
            db.SaveChanges();
            return new JsonResult(newBrand);
        }
        
    }
}
