using System.ComponentModel.DataAnnotations;
using XEasyShop.Windows;

namespace XEasyShop.DesktopClient.ViewModels
{
    public class CustomerViewModel:ViewModel
    {
        private string customerName;

        [Required]
        public string CustomerName {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged();
            }
        }
    }
}
