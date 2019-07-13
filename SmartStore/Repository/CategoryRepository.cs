using Microsoft.EntityFrameworkCore;
using SmartStore.DB;
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

        public override IQueryable<Category> GetAll()
        {
            var categories = base._db.Categories
                .Include(c => c.Children)
                .Where<Category>(c => c.ParentId == null);

            return categories;
        }
    }
}
