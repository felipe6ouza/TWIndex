using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWIndex.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TWIndex.ViewModels;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoTrabalho : ContentPage
    {
        public InfoTrabalho(Trabalho trabalho)
        {
            InitializeComponent();

            var viewModel = new InfoTrabalhoViewModel();

            viewModel.EntryTipo = trabalho.Tipo;
            this.BindingContext = viewModel;


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Trabalho>(this, "EntradaVerificada", (msg) =>
            {
                DisplayAlert("Página ainda não implementada", "Volte em breve", "OK");
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Trabalho>(this, "EntradaVerificada");
        }
    }
}