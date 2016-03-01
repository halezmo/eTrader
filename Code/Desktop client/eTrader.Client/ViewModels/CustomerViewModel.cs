using eTrader.Windows;
using System.ComponentModel.DataAnnotations;

namespace eTrader.Client.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private string customerName;

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
                NotifyPropertyChanged();
            }
        }
    }
}
