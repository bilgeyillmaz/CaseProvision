using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using Core.Utilities.Serializer;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CurrencyManager : ICurrencyService
    {
        ICurrencyDal _currencyDal;
        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }

        public IResult Add(CurrencyModel currency)
        {
            _currencyDal.Add(currency);
            return new SuccessResult();
        }

        public IResult Delete(CurrencyModel currency)
        {
            _currencyDal.Delete(currency);
            return new SuccessResult();
        }
        //[CacheAspect]
        public IDataResult<List<CurrencyModel>> GetAll()
        {
            return new SuccessDataResult<List<CurrencyModel>>(_currencyDal.GetAll());
        }
        //[CacheAspect]
        public IDataResult<CurrencyModel> GetById(int currencyId)
        {
            return new SuccessDataResult<CurrencyModel>(_currencyDal.Get(c => c.Id == currencyId));
        }

        public IResult Update(CurrencyModel currency)
        {
            _currencyDal.Update(currency);
            return new SuccessResult();
        }

        private string urlPath = "https://www.tcmb.gov.tr/kurlar/202206/03062022.xml";
        private readonly WebClient client = new WebClient();
        private readonly XmlSerializer serializer = new XmlSerializer();

        public Task<CurrencyModel[]> GetToday()
        {
            var url = urlPath;
            var data = client.DownloadString(url);
            var deserialize = serializer.Deserializer<Tarih_Date>(data);
            var result = deserialize.Currency.Select(CurrencyModel.Map).ToArray();

            for (int i = 0; i < result.Length; i++)
            {
                CurrencyModel model = new CurrencyModel()
                {
                    Unit = result[i].Unit,
                    Isim = result[i].Isim,
                    CurrencyName = result[i].CurrencyName ,
                    ForexBuying = result[i].ForexBuying,
                    ForexSelling = result[i].ForexSelling,
                    BanknoteBuying = result[i].BanknoteBuying,
                    BanknoteSelling = result[i].BanknoteSelling,
                    CrossRateUSD = result[i].CrossRateUSD,
                    CrossRateOther = result[i].CrossRateOther,
                    Currency = result[i].Currency
                };
                _currencyDal.Add(model);
            }
            return Task.FromResult(result);

        }
        private string _urlPath = "https://www.tcmb.gov.tr/kurlar/{0}.xml"; 

        //[CacheAspect]
        public Task<CurrencyModel[]> GetByDate(DateTime date)
        {
            var day = date.Day > 0 && date.Day < 10 ? $"0{date.Day}" : date.Day.ToString();
            var month = date.Month > 0 && date.Month < 10 ? $"0{date.Month}" : date.Month.ToString();
            var url = new Uri(string.Format(_urlPath, $"{date.Year}{month}/{day}{month}{date.Year}"));
            var data = client.DownloadString(url);
            var deserializer = serializer.Deserializer<Tarih_Date>(data);
            var result = deserializer.Currency.Select(CurrencyModel.Map).ToArray();
            return Task.FromResult(result);
        }


    }
}
