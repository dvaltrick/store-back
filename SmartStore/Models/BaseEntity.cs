using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatadedBy { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
