using System;
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

    }
}