using CarRestAPI.Core.DataAccess.EntityFramework;
using CarRestAPI.DataAccess.Abstract;
using CarRestAPI.DataAccess.Concrete.EntityFramework.Context;
using CarRestAPI.Entities.Concrete;

namespace CarRestAPI.DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
    }
}
