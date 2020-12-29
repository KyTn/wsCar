using CarRestAPI.Business.Abstract;
using CarRestAPI.Core.Utilities;
using CarRestAPI.Core.Utilities.Results;
using CarRestAPI.DataAccess.Abstract;
using CarRestAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRestAPI.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        /// <summary>
        /// this is a method blabla lba
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public IResult Add(Car car)
        {
            try
            {
                bool result = _carDal.Add(car);
                return result
                    ? (IResult)new SuccessResult(GeneralMessages.DATA_ADDED_SUCCESSFULLY)
                    : new ErrorResult(GeneralMessages.DATA_ADDING_ERROR);
            }
            catch (Exception ex)
            {
                return new ErrorResult(GeneralMessages.SOMETHING_WENT_WRONG + " Exception Detail: " + ex.Message);
            }
        }

        public IResult Delete(Car car)
        {
            try
            {
                bool result = _carDal.Delete(car);
                return result
                    ? (IResult)new SuccessResult(GeneralMessages.DATA_DELETED_SUCCESSFULLY)
                    : new ErrorResult(GeneralMessages.DATA_DELETING_ERROR);
            }
            catch (Exception ex)
            {
                return new ErrorResult(GeneralMessages.SOMETHING_WENT_WRONG + " Exception Detail: " + ex.Message);
            }
        }

        public IDataResult<List<Car>> GetAll()
        {
            try
            {
                var value = _carDal.GetList().ToList();

                return value != null
                    ? (IDataResult<List<Car>>)new SuccessDataResult<List<Car>>(value)
                    : new ErrorDataResult<List<Car>>(GeneralMessages.LIST_NOT_FOUND);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Car>>(GeneralMessages.SOMETHING_WENT_WRONG + " Exception Detail: " + ex.Message);
            }
        }

        public IDataResult<Car> GetById(int id)
        {
            try
            {
                var value = _carDal.Get(x => x.Id == id);

                return value != null
                    ? (IDataResult<Car>)new SuccessDataResult<Car>(value)
                    : new ErrorDataResult<Car>(GeneralMessages.DATA_NOT_FOUND);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Car>(GeneralMessages.SOMETHING_WENT_WRONG + " Exception Detail: " + ex.Message);
            }
        }

        public IResult Update(Car car)
        {
            try
            {
                bool result = _carDal.Update(car);
                return result
                    ? (IResult)new SuccessResult(GeneralMessages.DATA_UPDATED_SUCCESSFULLY)
                    : new ErrorResult(GeneralMessages.DATA_UPDATING_ERROR);
            }
            catch (Exception ex)
            {
                return new ErrorResult(GeneralMessages.SOMETHING_WENT_WRONG + " Exception Detail: " + ex.Message);
            }
        }
    }
}
