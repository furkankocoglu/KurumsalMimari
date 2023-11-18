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
    public class EmployeeManager :IEmployeeService<Employee>
    {
        IEmployeeDal _empdal;
        public EmployeeManager(IEmployeeDal empdal)
        {
            _empdal = empdal;
        }
        public IResult Add(Employee entity)
        {
            return _empdal.Add(entity);
        }

        public IResult Delete(Employee entity)
        {
            return _empdal.Delete(entity);
        }

        public IDataResult<Employee> Get(Expression<Func<Employee, bool>> filter)
        {
            return _empdal.Get(filter);
        }

        public IDataResult<List<Employee>> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            return _empdal.GetAll(filter);
        }

        public IResult Update(Employee entity)
        {
            return _empdal.Update(entity);
        }
    }
}
