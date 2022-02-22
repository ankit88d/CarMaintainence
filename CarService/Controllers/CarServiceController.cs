using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarServiceController : ControllerBase
    {       

        private readonly ICarBL carbl;
        public static List<Car> carList = new List<Car>();

        public CarServiceController(ICarBL icarbl)
        {
            carbl = icarbl;
        }
       
        [HttpGet]
        public List<Car> GetCarDetails()
        {
            return carbl.GetCarDetails(carList);
        }

        [HttpPost]
        public List<Car> AddCarService(Car carObj)
        {
            return carbl.AddCarForServicing(carObj, carList);
            
        }
    }
}
