using Cacuci_Daciana_12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Cacuci_Daciana_12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}