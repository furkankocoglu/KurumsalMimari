using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentCarDal : EfEntityRepositoryBase<RentCar, RentACarContext>, IRentCarDal
    {
        public IDataResult<List<RentCarDetailDto>> GetDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.RentCars
                             join c in context.Customers on r.CustomerId equals c.Id
                             join ca in context.Cars on r.CarId equals ca.Id
                             join e in context.Employees on r.EmployeeId equals e.Id
                             select new RentCarDetailDto
                             {
                                 Id = r.Id,
                                 CustomerName= c.Name,
                                 CustomerPhone = c.Phone,
                                 EmployeeName = e.Name,
                                 CarName = ca.Name
                             };
                return new SuccessDataResult<List<RentCarDetailDto>>(result.ToList());
            }
            


        }
    }
}
