using TWIndex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormPalavrasPage : ContentPage
    {
        
        public FormPalavrasPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<FormPalavrasViewModel, int>(this, "QuantidadePalavras", (sender, arg) =>
            {
                int valor = arg;

                for (var i = 0; i < valor; i++)
                {

                    var entry = new Entry();
                    entry.Placeholder = string.Format("Palavra-Chave {0}", i + 1);
                    entry.SetBinding(Entry.TextProperty, string.Format("Palavra{0}", i + 1));
                    Panel.Children.Add(entry);
                }
            });

          
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<FormPalavrasViewModel, int>(this, "QuantidadePalavras");
        }
    }
}