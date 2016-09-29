

using System.Runtime.Remoting.Contexts;

namespace XEasyShop.Data
{
    using System;
    using Prototype.Fuctional;

    public sealed class BussinessContext:IDisposable
    {
        private readonly DataContext _context;
        private bool _disposed;
        public BussinessContext()
        {
            _context=new DataContext();
        }

        public DataContext DataContext
        {
            get
            {
                return _context;
            }
        }

        public void AddNewCurrency(Сurrency сurrency)
        {
            Check.Require(nameof(сurrency.CurrencyName));

            _context.Сurrencies.Add(сurrency);
            _context.SaveChanges();
        }

        static class Check
        {
            public static void Require(string value)
            {
                if(value==null)
                    throw new ArgumentNullException();
                else if (value.Trim().Length == 0)
                
                    throw new ArgumentException();
            }
        }
        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed || disposing)
                return;
            _context?.Dispose();
            _disposed = true;
        }

        #endregion


    }
}
