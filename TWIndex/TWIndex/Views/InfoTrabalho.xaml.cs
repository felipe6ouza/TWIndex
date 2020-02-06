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

            MessagingCenter.Subscribe<InfoTrabalhoViewModel>(this, "EntradaVerificada", (msg) =>
            {
                int convertedNumericUpDown = -1;
                convertedNumericUpDown = Convert.ToInt32(msg.ValorNumericUpDown);
                Navigation.PushAsync(new InserirTermosBusca(convertedNumericUpDown));
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Trabalho>(this, "EntradaVerificada");
        }
    }
}