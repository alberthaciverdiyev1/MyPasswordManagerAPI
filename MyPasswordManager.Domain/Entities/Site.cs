using MyPasswordManager.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswordManager.Domain.Entities
{
    public class Site : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Logo { get; set; }
        public bool IsActive { get; set; }
    }
}
