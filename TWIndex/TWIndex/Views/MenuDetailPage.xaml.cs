using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWIndex.Models;
using TWIndex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetailPage : ContentPage
    {
        private MenuDetailViewModel ViewModel => BindingContext as MenuDetailViewModel;

        public MenuDetailPage()
        {
            InitializeComponent();
            BindingContext = new MenuDetailViewModel();
        }


      
    }
}