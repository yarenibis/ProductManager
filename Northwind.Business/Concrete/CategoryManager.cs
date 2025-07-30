using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal dal;
        public CategoryManager (ICategoryDal dal)
        {
            this.dal = dal;
        }

  

        public List<Category> GetAll()
        {
            return dal.GetAll();    
        }
    }
}
