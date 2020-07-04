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
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new TipoTrabalhoPage());

        }
        private void GoSobre(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Sobre());
            IsPresented = false;
        }
    }
}