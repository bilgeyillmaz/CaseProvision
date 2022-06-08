using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICurrencyDal
    {
        List<CurrencyModel> _currencyModels;
        public void Add(CurrencyModel currency)
        {
            _currencyModels.Add(currency);
        }

        public void Delete(CurrencyModel currency)
        {
            CurrencyModel currencyToDelete = _currencyModels.SingleOrDefault(c => c.Id == currency.Id);

            _currencyModels.Remove(currencyToDelete);
        }

        public CurrencyModel Get(Expression<Func<CurrencyModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CurrencyModel> GetAll()
        {
            return _currencyModels;
        }

        public List<CurrencyModel> GetAll(Expression<Func<CurrencyModel, bool>> filter = null)
        {
            return _currencyModels;
        }

        public void Update(CurrencyModel currency)
        {

            CurrencyModel currencyModelToUpdate = _currencyModels.SingleOrDefault((c => c.Id == currency.Id));
            currencyModelToUpdate.Isim = currency.Isim;
            currencyModelToUpdate.Unit = currency.Unit;
            currencyModelToUpdate.BanknoteBuying = currency.BanknoteBuying;
            currencyModelToUpdate.BanknoteSelling = currency.BanknoteSelling;
            currencyModelToUpdate.CrossRateOther = currency.CrossRateOther;
            currencyModelToUpdate.CrossRateUSD = currency.CrossRateUSD;
            currencyModelToUpdate.Currency = currency.Currency;
        }

        //public CurrencyModel Get(int currencyId)
        //{
        //    return _currencyModels.Where(c => c.Id == currencyId);
        //}
    }
}
