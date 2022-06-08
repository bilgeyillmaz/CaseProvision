using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CurrencyModel : IEntity
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public string Isim { get; set; }
        public string CurrencyName { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string BanknoteBuying { get; set; }
        public string BanknoteSelling { get; set; }
        public string CrossRateUSD { get; set; }
        public string CrossRateOther { get; set; }
        public string Currency { get; set; }

        //       <Currency CrossOrder = "13" Kod="RON" CurrencyCode="RON">
        //		<Unit>1</Unit>
        //		<Isim>RUMEN LEYİ</Isim>
        //		<CurrencyName>NEW LEU</CurrencyName>
        //		<ForexBuying>3.3907</ForexBuying>
        //		<ForexSelling>3.4351</ForexSelling>
        //		<BanknoteBuying></BanknoteBuying>
        //		<BanknoteSelling></BanknoteSelling>
        //			<CrossRateUSD>4.6481</CrossRateUSD>
        //			<CrossRateOther/>

        //</Currency>
        public static CurrencyModel Map(Tarih_DateCurrency x)
        {
            return new CurrencyModel
            {
                Unit = x.Unit,
                Isim = x.Isim,
                CurrencyName = x.CurrencyName,
                ForexBuying = x.ForexBuying,
                ForexSelling = x.ForexSelling,
                BanknoteBuying = x.BanknoteBuying,
                BanknoteSelling = x.BanknoteSelling,
                CrossRateUSD = x.CrossRateUSD,
                CrossRateOther = x.CrossRateOther,
                Currency = x.CurrencyCode
            };
        }
    }
}
