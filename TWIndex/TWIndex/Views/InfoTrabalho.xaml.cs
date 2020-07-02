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


        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;

            stepperLabel.Text = string.Format("{0}", value);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<InfoTrabalhoViewModel>(this, "EntradaVerificada", (msg) =>
            {
                int ConvertedValorStepper = -1;
                ConvertedValorStepper = Convert.ToInt32(msg.ValorStepper);
                Navigation.PushAsync(new InserirTermosBusca(ConvertedValorStepper));
            });
        }



        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Trabalho>(this, "EntradaVerificada");
        }
    }
}