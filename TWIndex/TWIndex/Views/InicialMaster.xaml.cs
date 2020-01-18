using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TWIndex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialMaster : ContentPage
    {
        public ListView ListView;

        public InicialMaster()
        {
            InitializeComponent();

            BindingContext = new InicialMasterViewModel();
            ListView = MenuItemsListView;
        }

       
    }
}