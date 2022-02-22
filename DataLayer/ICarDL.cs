using Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface ICarDL
    {
        List<Car> GetCarDetails(List<Car> carList);
        List<Car> AddCarForServicing(Car carObj, List<Car> carList);
    }
}
