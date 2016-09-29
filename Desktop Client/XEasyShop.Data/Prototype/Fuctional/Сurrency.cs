using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEasyShop.Data.Prototype.Fuctional
{
    public class Сurrency
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование валюты
        /// </summary>
        public string CurrencyName { get; set; }

        public ICollection<ExchangeRate> ExchangeRates { get; set; }

        public Сurrency()
        {
             ExchangeRates=new List<ExchangeRate>();
        }
    }
}
