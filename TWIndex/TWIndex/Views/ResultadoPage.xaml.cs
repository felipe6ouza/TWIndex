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
    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<string>(this, "Erro", (msg) =>
            {
                FlexResult.IsVisible = false;
                ScrollResult.IsVisible = false;
                ErrorImage.IsVisible = true;
                ErrorTitle.IsVisible = true;
                DisplayAlert("Falha na Conexão", msg, "OK");


            });
        }
    }
}