using CarServicing.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CarServicing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<CarViewModel> carlist;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58738/");
                var responseTask = client.GetAsync("CarService");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<CarViewModel>>();
                    readTask.Wait();
                    carlist = readTask.Result;
                }
                else
                {
                    carlist = Enumerable.Empty<CarViewModel>();
                }
            }

            return View(carlist);
        }
     

            [HttpPost]     
        public ActionResult CarView(CarViewModel car)
        {          
            IEnumerable<CarViewModel> carlist;
            using (var client = new HttpClient())
            {                
                client.BaseAddress = new Uri("http://localhost:58738/");
                var response =  client.PostAsync("CarService", car, new JsonMediaTypeFormatter());

                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<CarViewModel>>();
                    readTask.Wait();
                    carlist = readTask.Result;
                }
                else
                {
                    carlist = Enumerable.Empty<CarViewModel>();
                }
            }
            return View("Index", carlist);

        }
        
        public ActionResult CarView()
        {
            return View();

        }


    }
}