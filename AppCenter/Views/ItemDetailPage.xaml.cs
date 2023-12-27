using AppCenter.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppCenter.Views
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