using CarRestAPI.Core.DataAccess;
using CarRestAPI.Entities.Concrete;

namespace CarRestAPI.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

    }
}
