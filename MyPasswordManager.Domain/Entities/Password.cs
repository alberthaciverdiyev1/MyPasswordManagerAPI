using MyPasswordManager.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswordManager.Domain.Entities
{
    public class Password : BaseEntity
    {
        public string EncryptedPassword { get; set; } = null!;
        public string SiteId { get; set; } = null!;
        public ICollection<Site> Sites { get; set; } = null!;
        public string? Description { get; set; }

    }
}
