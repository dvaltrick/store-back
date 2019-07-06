using SmartStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Repository
{
    public class CategoryRepository: GenericRepository<Category>
    {
        public override Category Create(Category entity)
        {
            return base.Create(entity);
        }
    }
}
