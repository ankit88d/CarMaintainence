using DataLayer;
using Repo;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BLClass : ICarBL
    {
        private readonly ICarDL cardl;
        public BLClass(ICarDL CarDl)
        {
           cardl = CarDl;
        }

        public List<Car> GetCarDetails(List<Car> carList)
        {
            var cardata = cardl.GetCarDetails(carList);
            return cardata;
        }

        public List<Car> AddCarForServicing(Car carObj, List<Car> carList)
        {
            return cardl.AddCarForServicing(carObj, carList);            
        }
    }
}
