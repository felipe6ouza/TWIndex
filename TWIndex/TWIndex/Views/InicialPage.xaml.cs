using MVVMCoffee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialPage : ContentPage
    {

        public bool Academic = false;
        public bool Business = false;



        public InicialPage()
        {
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            InitializeComponent();
            BindingContext = this;
        }


        public void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if(button.Text == "Acadêmico")
            {
                Academic = true;
                Business = false;

            }

            else if (button.Text == "Empresarial")
            {
                Academic = false;

                Business = true;
            }

            buttonNext.IsEnabled = true;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Academic)
                Navigation.PushAsync(new TipoTrabalhoPage());
            else
                Navigation.PushAsync(new FormEmpresaPage());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}