

using System.Collections.Generic;

namespace XEasyShop.Data.Prototype.Fuctional
{
    using System;

    /// <summary>
    /// Курс валют
    /// </summary>
    public class ExchangeRate
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Дата курса валют
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Значение валюты(курс)
        /// </summary>
        public decimal Value { get; set; }

        public ICollection<Сurrency> Сurrencies { get; set; }
        public ICollection<Product> Products { get; set; }
        public ExchangeRate()
        {
            Сurrencies=new List<Сurrency>();
            Products=new List<Product>();
        }
    }
}
