using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        
        public void CategoryAdd(Contact category)
        {
            efCategoryRepository.Insert(category);

        }
        

        public void CategoryDelete(Contact category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Contact category)
        {
            efCategoryRepository.Update(category);
        }

        public Contact GetByID(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Contact> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
