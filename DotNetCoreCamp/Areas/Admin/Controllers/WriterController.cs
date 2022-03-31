using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreCamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace DotNetCoreCamp.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]

    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);

        }
        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
        }
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }
        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                Name = "Berkcan"
            },
            new WriterClass
            {
                Id = 2,
                Name = "Şevval"
            },
            new WriterClass
            {
                Id = 3,
                Name = "Nurana"
            },
            new WriterClass
            {
                Id = 4,
                Name = "Mete Serkan"
            }

        };
    }
}
