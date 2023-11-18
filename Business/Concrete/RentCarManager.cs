using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentCarManager:IRentCarService<RentCar>
    {
        IRentCarDal _rentdal;
        public RentCarManager(IRentCarDal rentdal)
        {
            _rentdal = rentdal;
        }
        public IResult Add(RentCar entity)
        {
            return _rentdal.Add(entity);
        }

        public IResult Delete(RentCar entity)
        {
            return _rentdal.Delete(entity);
        }

        public IDataResult<RentCar> Get(Expression<Func<RentCar, bool>> filter)
        {
            return _rentdal.Get(filter);
        }

        public IDataResult<List<RentCar>> GetAll(Expression<Func<RentCar, bool>> filter = null)
        {
            return _rentdal.GetAll(filter);
        }

        public IDataResult<List<RentCarDetailDto>> GetDetails()
        {
            return _rentdal.GetDetails();
        }


        public IResult Update(RentCar entity)
        {
            return _rentdal.Update(entity);
        }
    }
}
