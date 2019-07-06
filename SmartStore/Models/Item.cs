using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class Item : BaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public Guid? CategoryId { get; set; } 
        public Category Category { get; set; }

        public Guid? SpecificationId { get; set; }
        public Specification Specification { get; set; }

        public IEnumerable<ItemPrice> PriceHistory { get; set; }

        public IEnumerable<ItemImage> Images { get; set; }

        public static Item Builder() {
            var item = new Item();
            item.Id = Guid.NewGuid();

            return item;
        }
    }
}
