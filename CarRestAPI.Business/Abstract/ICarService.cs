using CarRestAPI.Core.Utilities.Results;
using CarRestAPI.Entities.Concrete;
using System.Collections.Generic;

namespace CarRestAPI.Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
