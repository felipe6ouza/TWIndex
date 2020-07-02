using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWIndex.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MenuDetailPage());
        }


        private void GoSobre(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Sobre());
            IsPresented = false;
        }
    }
}