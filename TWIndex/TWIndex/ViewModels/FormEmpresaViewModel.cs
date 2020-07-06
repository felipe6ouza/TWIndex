using MVVMCoffee.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class FormEmpresaViewModel : BaseViewModel
    {
        public string _segmento;
        public string Segmento
        {
            get { return _segmento; }
            set
            {
                SetProperty(ref _segmento, value);
                ValidarCommand.ChangeCanExecute();
            }
        } 
        public string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                SetProperty(ref _nome, value);
                ValidarCommand.ChangeCanExecute();
            }
        }

        public string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set
            {
                SetProperty(ref _cidade, value);
                ValidarCommand.ChangeCanExecute();
            }
        }

        public string _estado;
        public string Estado
        {
            get { return _estado; }
            set
            {
                SetProperty(ref _estado, value);
                ValidarCommand.ChangeCanExecute();
            }
        }

        public Command ValidarCommand { get; private set; }

        public string _valorStepper = "4";
        public string ValorStepper
        {
            get { return _valorStepper; }

            set { SetProperty(ref _valorStepper, value); }
        }

        public FormEmpresaViewModel()
        {

            ValidarCommand = new Command(
          execute: () =>
          {
              int quantidadePalavras = int.Parse(ValorStepper);
              Navigation.PushAsync<FormPalavrasViewModel>(false, quantidadePalavras);
          },

            canExecute: () =>
            {
                bool validador = false;

                validador = !string.IsNullOrWhiteSpace(Segmento) &&
                 !string.IsNullOrWhiteSpace(Nome);
                 
                return validador;
            });

        }

    }
}
