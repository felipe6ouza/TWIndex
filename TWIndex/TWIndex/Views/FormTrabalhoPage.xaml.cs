using System;
using TWIndex.Models;
using TWIndex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormTrabalhoPage : ContentPage
    {
        public FormTrabalhoPage()
        {
            InitializeComponent();   
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;

            stepperLabel.Text = string.Format("{0}", value);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<FormTrabalhoViewModel>(this, "EntradaVerificada", (msg) =>
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