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
        public FormTrabalhoPage(string tipo)
        {
            InitializeComponent();
            BindingContext = new FormTrabalhoViewModel(tipo);
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;

            stepperLabel.Text = string.Format("{0}", value);

        }

    }
}