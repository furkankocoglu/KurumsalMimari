using Core.Business;
using Core.Entities;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentCarService<T> : IService<T> where T : class, IEntity, new()
    {
        IDataResult<List<RentCarDetailDto>> GetDetails();
    }
}
