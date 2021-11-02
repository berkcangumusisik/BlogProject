using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.ViewComponents.Writer
{

    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterByID(1);
            return View(values);

        }
    }
}
