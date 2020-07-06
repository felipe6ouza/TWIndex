using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TWIndex.Models;
using Xamarin.Forms;
using MVVMCoffee.ViewModels;
using MVVMCoffee.Services;
using TWIndex.Views;

namespace TWIndex.ViewModels
{
    public class TipoTrabalhoViewModel : BaseViewModel
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
                {
                    var str = TipoSelecionado.Nome;
                    ExecutePushAsyncCommand(str);
                }
                    

            }
        }


        private async void ExecutePushAsyncCommand(string tipo)
        {

            await Navigation.PushAsync<FormTrabalhoViewModel>(false, tipo);

        }

        public ObservableCollection<Tipo> TiposTrabalho { get; }

        public TipoTrabalhoViewModel()
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

