using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TWIndex.Models;
using Xamarin.Forms;
using MVVMCoffee.ViewModels;

namespace TWIndex.ViewModels
{
    public class MenuDetailViewModel : BaseViewModel
    {
        public Tipo _tipoSelecionado;

        public Tipo TipoSelecionado
        {
            get
            {
                return _tipoSelecionado;
            }

            set
            {
                SetProperty(ref _tipoSelecionado, value);

                if (value != null)
                    ExecutePush();


            }
        }

        private async void ExecutePush()
        {
            var str = TipoSelecionado.Nome;
            await Navigation.PushAsync<FormTrabalhoViewModel>(false, str);
        }

        public ObservableCollection<Tipo> TiposTrabalho { get; }

        public MenuDetailViewModel()
        {
            TiposTrabalho = new ObservableCollection<Tipo>();

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Doutorado"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Mestrado"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Trabalho de Conclusão de Curso"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Relatório Técnico"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Relatório Científico"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Iniciação Tecnológica"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Iniciação Científica"
            });

            TiposTrabalho.Add(new Tipo
            {
                Nome = "Patente"
            });
        }
    }
}

