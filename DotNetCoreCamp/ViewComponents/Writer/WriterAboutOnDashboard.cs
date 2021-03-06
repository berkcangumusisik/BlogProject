using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace DotNetCoreCamp.ViewComponents.Writer
{

    public class WriterAboutOnDashboard:ViewComponent
    {
        

        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        

        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            ViewBag.v = userName;
            var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterByID(writerID);
            return View(values);
        }
    }
}
