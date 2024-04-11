using MyPasswordManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswordManager.Application.Abstraction.Repositories
{
    internal interface IPasswordRepository:IRepository<Password>
    {
    }
}
