using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService<Car>
    {
        ICarDal _cardal;
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }
        public IResult Add(Car entity)
        {
            if (entity.Plaque.Length<6)
            {
                return new ErrorResult(Message.InvalidInput);
            }
           _cardal.Add(entity);
           return new SuccessResult(Message.DataAdded);
        }

        public IResult Delete(Car entity)
        {
            _cardal.Delete(entity);
			return new SuccessResult(Message.DataDeleted);
		}

		public IDataResult<Car> Get(Expression<Func<Car, bool>> filter)
        {
            return new SuccessDataResult<Car>(_cardal.Get(filter).Data, Message.DatasListed);
        }

        public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
			return new SuccessDataResult<List<Car>>(_cardal.GetAll(filter).Data, Message.DatasListed);
		}

        public IResult Update(Car entity)
        {
			if (entity.Plaque.Length < 6)
			{
				return new ErrorResult(Message.InvalidInput);
			}
			_cardal.Update(entity);
			return new SuccessResult(Message.DataUpdated);
		}
    }
}
