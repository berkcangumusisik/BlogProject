using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            ViewBag.ToplamBlogSayisi = blogManager.GetList().Count();
            ViewBag.YazarinBlogSayisi = blogManager.GetBlogListByWriter(1).Count();
            ViewBag.KategoriSayisi = categoryManager.GetList().Count();
            return View();
        }
    }
}
