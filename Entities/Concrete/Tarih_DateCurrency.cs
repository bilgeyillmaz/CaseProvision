using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Tarih_DateCurrency
    {

        private string unitField;

        private string isimField;

        private string currencyNameField;

        private string forexBuyingField;

        private string forexSellingField;

        private string banknoteBuyingField;

        private string banknoteSellingField;

        private string crossRateUSDField;

        private string crossRateOtherField;

        private string crossOrderField;

        private string kodField;

        private string currencyCodeField;

        /// <remarks/>
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string Isim
        {
            get
            {
                return this.isimField;
            }
            set
            {
                this.isimField = value;
            }
        }

        /// <remarks/>
        public string CurrencyName
        {
            get
            {
                return this.currencyNameField;
            }
            set
            {
                this.currencyNameField = value;
            }
        }

        /// <remarks/>
        public string ForexBuying
        {
            get
            {
                return this.forexBuyingField;
            }
            set
            {
                this.forexBuyingField = value;
            }
        }

        /// <remarks/>
        public string ForexSelling
        {
            get
            {
                return this.forexSellingField;
            }
            set
            {
                this.forexSellingField = value;
            }
        }

        /// <remarks/>
        public string BanknoteBuying
        {
            get
            {
                return this.banknoteBuyingField;
            }
            set
            {
                this.banknoteBuyingField = value;
            }
        }

        /// <remarks/>
        public string BanknoteSelling
        {
            get
            {
                return this.banknoteSellingField;
            }
            set
            {
                this.banknoteSellingField = value;
            }
        }

        /// <remarks/>
        public string CrossRateUSD
        {
            get
            {
                return this.crossRateUSDField;
            }
            set
            {
                this.crossRateUSDField = value;
            }
        }

        /// <remarks/>
        public string CrossRateOther
        {
            get
            {
                return this.crossRateOtherField;
            }
            set
            {
                this.crossRateOtherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CrossOrder
        {
            get
            {
                return this.crossOrderField;
            }
            set
            {
                this.crossOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Kod
        {
            get
            {
                return this.kodField;
            }
            set
            {
                this.kodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
    }
}
