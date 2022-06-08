using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICurrencyService
    {
        IDataResult<List<CurrencyModel>> GetAll();
        IDataResult<CurrencyModel> GetById(int currencyModel);
        IResult Add(CurrencyModel currencyModel);
        IResult Delete(CurrencyModel currencyModel);
        IResult Update(CurrencyModel currencyModel);
        Task<CurrencyModel[]> GetToday();
        Task<CurrencyModel[]> GetByDate(DateTime date);
    }
}
