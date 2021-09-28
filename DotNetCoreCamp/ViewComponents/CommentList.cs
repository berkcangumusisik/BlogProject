using DotNetCoreCamp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="Berkcan"
                },
                new UserComment
                {
                    ID = 2,
                    UserName="İbrahim"
                },
                new UserComment
                {
                    ID = 3,
                    UserName="Murat"
                }
            };
            return View(commentValues);
        }
    }
}
