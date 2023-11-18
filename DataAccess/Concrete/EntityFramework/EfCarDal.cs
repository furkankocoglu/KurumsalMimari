
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<Car> Cars(string year)
        {
            using(RentACarContext rentACarContext= new RentACarContext())
            {
                return rentACarContext.Set<Car>().Where(c=>c.ModelYear == year).ToList();

            }
        }
    }
}
