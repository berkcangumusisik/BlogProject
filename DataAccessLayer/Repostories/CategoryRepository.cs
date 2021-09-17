using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Contact category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Contact category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Contact GetByID(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Contact> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void UpdateCategory(Contact category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
