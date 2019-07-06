using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class ItemPrice: BaseEntity
    {
        public Guid? ItemId { get; set; }

        public Item Item { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public float Price { get; set; }
    }
}
