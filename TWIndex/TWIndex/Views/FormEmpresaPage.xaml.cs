using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWIndex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormEmpresaPage : ContentPage
    {
        public FormEmpresaPage()
        {
            InitializeComponent();
            BindingContext = new FormEmpresaViewModel();
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;

            stpLabel.Text = string.Format("{0}", value);

        }

    }
}