using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TWIndex.Models;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class InfoTrabalhoViewModel : INotifyPropertyChanged
    {
  
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Trabalho trabalho = new Trabalho();



        public string EntryTipo
        {
            get
            {
                return trabalho.Tipo;
            }

            set
            {
                trabalho.Tipo = value;
            }

        }

        public string EntryTitulo
        {
            get { return this.trabalho.Titulo; }
            set
            {
                trabalho.Titulo = value;
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string EntryAutor
        {
            get { return this.trabalho.Autor; }
            set
            {
                trabalho.Autor = value;
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string EntryOrigem
        {
            get { return this.trabalho.Origem; }
            set
            {
                trabalho.Origem = value;
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string EntryDepartamento
        {
            get { return this.trabalho.Departamento; }
            set
            {
                trabalho.Departamento = value;
                ConfirmarCommand.ChangeCanExecute();
            }
        }

        public string _valorStepper = "2";
        public string ValorStepper
        {
            get
            {
                return _valorStepper;
            }

            set
            {
                _valorStepper = value;
                OnPropertyChanged(_valorStepper);
      
 
            }
        }

        public Command ConfirmarCommand { get; private set; }

        public InfoTrabalhoViewModel()
        {
            ConfirmarCommand = new Command(ExecutarConfirmar, () =>

               !string.IsNullOrWhiteSpace(trabalho?.Titulo) && !string.IsNullOrWhiteSpace(trabalho?.Autor) && !string.IsNullOrWhiteSpace(trabalho?.Origem) && !string.IsNullOrWhiteSpace(trabalho?.Departamento));
        }

        private void ExecutarConfirmar()
        {
            MessagingCenter.Send(this, "EntradaVerificada");
          
        }

    }
}
