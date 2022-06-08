using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyUI.Controllers
{
    public class CurrencyUIController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string url = "https://localhost:44351/get-currency-data";
            List<CurrencyModel> currencyDatas = new List<CurrencyModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    currencyDatas = JsonConvert.DeserializeObject<List<CurrencyModel>>(apiResponse).ToList();
                }
                ViewBag.currencyData = currencyDatas;
                return View();

            }
        }
    }
}
