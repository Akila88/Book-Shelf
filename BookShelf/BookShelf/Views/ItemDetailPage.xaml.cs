using BookShelf.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BookShelf.Views
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