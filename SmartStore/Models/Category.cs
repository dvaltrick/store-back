using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class Category : BaseEntity
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Icon { get; set; }
        public Guid? ParentId { get; set; }
        public Category Parent { get; set; }
        public IEnumerable<Category> Children { get; set; }
        public IEnumerable<Item> Items { get; set; }

        public static Category Builder() {
            var category = new Category();
            category.Id = Guid.NewGuid();

            return category;
        }
    }
}
