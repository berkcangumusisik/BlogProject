using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public bool Exists { get; set; }
    }
}
