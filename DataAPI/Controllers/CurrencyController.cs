using Business.Abstract;
using Core.Utilities.Serializer;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        CurrencyDbContext context = new CurrencyDbContext();
        ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _currencyService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _currencyService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CurrencyModel currency)
        {
            var result = _currencyService.Add(currency);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(CurrencyModel currency)
        {
            var result = _currencyService.Delete(currency);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(CurrencyModel currency)
        {
            var result = _currencyService.Update(currency);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get-today")]
        public async Task<IActionResult> GetToday()
        {
            return Ok(await _currencyService.GetToday());
        }
        [HttpGet("get-by-date")]
        public async Task<IActionResult> GetByDate(DateTime date)
        {
            return Ok(await _currencyService.GetByDate(date));
        }
    }
}
