using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IService<T>:IEntityRepository<T> where T : class, IEntity, new() 
    {       

    }
}
