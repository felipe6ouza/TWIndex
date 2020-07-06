using MVVMCoffee.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TWIndex.Models;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class FormTrabalhoViewModel : BaseViewModel
    {

        public Trabalho trabalho = new Trabalho();

        public string Tipo { get; set; }

        public string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                SetProperty(ref _titulo, value);
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string _autor;

        public string Autor
        {
            get { return _autor; }
            set
            {
                SetProperty(ref _autor, value);
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string _origem;
        public string Origem
        {
            get { return _origem; }
            set
            {
                SetProperty(ref _origem, value);
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string _departamento;
        public string Departamento
        {
            get { return _departamento; }
            set
            {
                SetProperty(ref _departamento, value);
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string _valorStepper = "4";
        public string ValorStepper
        {
            get { return _valorStepper; }

            set { SetProperty(ref _valorStepper, value); }
        }

        public Command ConfirmarCommand { get; private set; }

        public FormTrabalhoViewModel(string tipoTrabalho)
        {
            Tipo = tipoTrabalho;

            ConfirmarCommand = new Command(
          execute: () =>
          {
              int quantidadePalavras = int.Parse(ValorStepper);
              Navigation.PushAsync<FormPalavrasViewModel>(false, quantidadePalavras);
          },

            canExecute: () =>
            {
                bool validador = false;

                validador = !string.IsNullOrWhiteSpace(Titulo) &&
                 !string.IsNullOrWhiteSpace(Autor) &&
                 !string.IsNullOrWhiteSpace(Origem) &&
                 !string.IsNullOrWhiteSpace(Departamento);

                return validador;
            });

        }


    }
}
