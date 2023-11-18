using Business.Abstract;
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
    public class CustomerManager:ICustomerService<Customer>
    {
        ICustomerDal _cusdal;
        public CustomerManager(ICustomerDal cusdal)
        {
            _cusdal = cusdal;
        }
        public IResult Add(Customer entity)
        {
            return _cusdal.Add(entity);
        }

        public IResult Delete(Customer entity)
        {
            return _cusdal.Delete(entity);
        }

        public IDataResult<Customer> Get(Expression<Func<Customer, bool>> filter)
        {
            return _cusdal.Get(filter);
        }

        public IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _cusdal.GetAll(filter);
        }

        public IResult Update(Customer entity)
        {
            return _cusdal.Update(entity);
        }
    }
}
