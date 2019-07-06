using SmartStore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class Specification: BaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Display { get; set; }

        public SpecificationType Type { get; set; }

        public IEnumerable<Item> Items { get; set; }

        public IEnumerable<SpecificationUnit> Units { get; set; }

        public static Specification Builder() {
            var specification = new Specification();
            specification.Id = Guid.NewGuid();

            return specification;
        }
    }
}
