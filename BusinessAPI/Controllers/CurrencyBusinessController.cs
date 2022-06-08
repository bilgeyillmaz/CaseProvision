using Business.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAPI.Controllers
{
    public class CurrencyBusinessController : Controller
    {
        private ICurrencyService _currencyService;

        public CurrencyBusinessController( ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet("get-currency-data")]
        public IActionResult GetToday()
        {
            return Json(_currencyService.GetAll().Data);
        }
    }
}
