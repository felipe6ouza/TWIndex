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
    public partial class TipoTrabalhoPage : ContentPage
    {

        public TipoTrabalhoPage()
        {
            InitializeComponent();
            BindingContext = new TipoTrabalhoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<TipoTrabalhoViewModel, string>(this, "TipoTrabalhoSelecionado", (sender, args) =>
            {
                Application.Current.MainPage = new NavigationPage(new FormTrabalhoPage(args));

            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<TipoTrabalhoViewModel, string>(this, "TipoTrabalhoSelecionado");
        }

    }
}