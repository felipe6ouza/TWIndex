using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class InserirTermosBusca : ContentPage
    {
        public InserirTermosBusca(int valor)
        {
            InitializeComponent();
            this.BindingContext = new InserirTermosBuscaViewModel(valor);

            for (var i = 0; i < valor; i++)
            {

                var entry = new Entry();
                entry.Placeholder = string.Format("Palavra-Chave {0}", i + 1);
                entry.SetBinding(Entry.TextProperty, string.Format("Entry{0}", i + 1));
                Panel.Children.Add(entry) ;
            }
        }


       protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Busca>(this, "PalavrasChaveVerificadas", (msg) =>
            {
                DisplayAlert("Realizar Busca", "Implementação na próxima versão", "Ok");
            }

            );

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<Busca>(this, "PalavrasChaveVerificadas");
        }
    }
}