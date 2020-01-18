using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TWIndex.Models;

namespace TWIndex.ViewModels
{
    class InicialMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<InicialMasterMenuItem> MenuItems { get; set; }

        public InicialMasterViewModel()
        {
            MenuItems = new ObservableCollection<InicialMasterMenuItem>(new[]
            {
                    new InicialMasterMenuItem { Id = 0, Title = "Contato" },
                    new InicialMasterMenuItem { Id = 1, Title = "Configurações" },
                    new InicialMasterMenuItem { Id = 2, Title = "Sobre" },
                    new InicialMasterMenuItem { Id = 3, Title = "Sair" },
                     
            });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
