using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear =2022,DailyPrice=1000,Description="C segment araç"},
                new Car {CarId=2,BrandId=2,ColorId=1,ModelYear=2024,DailyPrice=1500,Description= "B segment araç"},
                new Car {CarId=3,BrandId=2,ColorId=2,ModelYear=2023,DailyPrice=1250,Description="D segment araç"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=>c.CarId==car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car carToUpdate=_car.SingleOrDefault(c=>c.CarId== car.CarId);
            carToUpdate.CarId= car.CarId;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
        }
        public List<Car> GetAllById(int carId)
        {
            return _car.Where(c=> c.CarId==carId).ToList(); 
        }
    }
}
