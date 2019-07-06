using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    interface IEntity
    {
        Guid Id { get; set; }
    }
}
