using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class SpecificationUnit: BaseEntity
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public string Display { get; set; }

        public Guid? SpecificationId { get; set; }

        public Specification Specification { get; set; }
    }
}
