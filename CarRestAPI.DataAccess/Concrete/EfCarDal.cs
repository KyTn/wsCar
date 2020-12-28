using CarRestAPI.Core.DataAccess;
using CarRestAPI.Core.DataAccess.EntityFramework;
using CarRestAPI.DataAccess.Abstract;
using CarRestAPI.DataAccess.Concrete.EntityFramework.Context;
using CarRestAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRestAPI.DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
    }
}
