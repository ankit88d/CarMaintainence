using Repo;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class DLClass : ICarDL
    {
        public List<Car> GetCarDetails(List<Car> carList)
        {
            return carList;
        }

        public List<Car> AddCarForServicing(Car carObj, List<Car> carList)
        {
            string status = "Waiting";
               
            if (carList.Count <= 10) {
                status = carObj.Status;
            }
            carList.Add(new Car
            {
                RegistrationNumber = carObj.RegistrationNumber,
                Owner = carObj.Owner,
                Model = carObj.Model,
                Make = carObj.Make,
                Service = carObj.Service,
                Status = status
            });
            return carList;
        }
    }
}
