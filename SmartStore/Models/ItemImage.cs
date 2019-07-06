using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class ItemImage: BaseEntity
    {
        public Guid? ItemId { get; set; }

        public Item Item { get; set; }

        public int Sequence { get; set; }

        public string ImageSource { get; set; }
    }
}
