using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Contact category);
        void CategoryDelete(Contact category);
        void CategoryUpdate(Contact category);
        List<Contact> GetList();
        Contact GetByID(int id);
    }
}
