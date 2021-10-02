using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Models
{
    public class CityAndWriter
    {
        public List<Cities> Cities { get; set; }
        public List<Writer> Writers { get; set; }
    }
}
