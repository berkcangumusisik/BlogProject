using DotNetCoreCamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreCamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]

    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                Categoryname = "Teknoloji",
                Categorycount = 10
            });
            list.Add(new CategoryClass
            {
                Categoryname = "Yazılım",
                Categorycount = 14
            });
            list.Add(new CategoryClass
            {
                Categoryname = "Spor",
                Categorycount = 5
            });
            list.Add(new CategoryClass
            {
                Categoryname = "Sinema",
                Categorycount = 2
            });
            return Json(new { jsonlist = list });
        }
    }
}