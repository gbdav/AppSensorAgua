using AppSensorAgua.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppSensorAgua.Views
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