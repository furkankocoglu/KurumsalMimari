using Core.Business;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService<T>:IService<T> where T : class, IEntity, new()

    {
    }
}
