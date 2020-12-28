using CarRestAPI.Core.DataAccess;
using CarRestAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRestAPI.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

    }
}
