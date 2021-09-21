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
       

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        

        public Category GetByID(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        
        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        
    }
}
