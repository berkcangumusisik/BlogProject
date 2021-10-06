using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());



        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PartialAddComment()
        {
            return View();
        }
        [HttpPost]

        public IActionResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 2;
            cm.CommentAdd(p);
            return RedirectToAction("BlogReadAll", "Blog", new { id = p.BlogID });

        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }


    }
}
