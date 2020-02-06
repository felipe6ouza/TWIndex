using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TWIndex.Models;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class InserirTermosBuscaViewModel : INotifyPropertyChanged
    {

        public Busca Busca = new Busca();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
 
        public Command ValidarCommand { get; private set; }

        protected int quantidadePalavras { get; set; }

        private List<string> listaAuxiliar = new List<string>();

        private string _entry1 { get; set; }

        private string _entry2 { get; set; }

        private string _entry3 { get; set; }

        private string _entry4 { get; set; }

        private string _entry5 { get; set; }

        private string _entry6 { get; set; }

        public string Entry1
        {
            get
            {
                return _entry1;
            }


            set
            {
                if (value != null)
                {
                    _entry1 = value;
                    OnPropertyChanged(_entry1);
                    ValidarCommand.ChangeCanExecute();
                }
            }
        }

        public string Entry2
        {
            get
            {
                return _entry2;
            }


            set
            {
                if (value != null)
                {
                    _entry2 = value;
                    OnPropertyChanged(_entry2);
                    ValidarCommand.ChangeCanExecute();
                }
            }
        }

        public string Entry3
        {
            get
            {
                return _entry3;
            }


            set
            {
                if (value != null)
                {
                    _entry3 = value;
                    OnPropertyChanged(_entry3);

                    ValidarCommand.ChangeCanExecute();
                }
            }
        }

        public string Entry4
        {
            get
            {
                return _entry4;
            }


            set
            {
                if (value != null)
                {
                    _entry4 = value;
                    OnPropertyChanged(_entry4);
                    ValidarCommand.ChangeCanExecute();
                }
            }
        }

        public string Entry5
        {
            get
            {
                return _entry5;
            }


            set
            {
                if (value != null)
                {
                    _entry5 = value;
                    OnPropertyChanged(_entry5);
                    ValidarCommand.ChangeCanExecute();
                }
            }
        }

        public string Entry6
        {
            get
            {
                return _entry6;
            }


            set
            {
                if (value != null)
                {
                    _entry6 = value;
                    OnPropertyChanged(_entry6);
                    ValidarCommand.ChangeCanExecute();
                }
            }
        }


        public InserirTermosBuscaViewModel(int quantidadePalavras)
        {
            this.quantidadePalavras = quantidadePalavras;


            ValidarCommand = new Command(
                execute: () =>
            {
                listaAuxiliar.Add(_entry1);
                listaAuxiliar.Add(_entry2);
                listaAuxiliar.Add(_entry3);
                listaAuxiliar.Add(_entry4);
                listaAuxiliar.Add(_entry5);
                listaAuxiliar.Add(_entry6);

                for (int i = 0; i< quantidadePalavras; i++)
                {
                    if (!string.IsNullOrEmpty(listaAuxiliar[i]))
                    {
                        Busca.ListaPalavrasChave.Add(listaAuxiliar[i]);
                    }
                }
               
                MessagingCenter.Send(this.Busca, "PalavrasChaveVerificadas");
            },

            canExecute: () =>
            {
                int caseSwitch = quantidadePalavras;

                bool validador = false;

                switch (caseSwitch)
                {
                    case 1:
                        validador = !string.IsNullOrEmpty(_entry1);
                        break;
                    case 2:
                          validador = !string.IsNullOrEmpty(_entry1) && !string.IsNullOrEmpty(_entry2);
                        break;
                    case 3:
                          validador =  !string.IsNullOrEmpty(_entry1) && !string.IsNullOrEmpty(_entry2) && !string.IsNullOrEmpty(_entry3);
                        break;
                    case 4:
                       validador = !string.IsNullOrEmpty(_entry1) && !string.IsNullOrEmpty(_entry2) && !string.IsNullOrEmpty(_entry3) && !string.IsNullOrEmpty(_entry4);
                        break;
                    case 5:
                        validador = !string.IsNullOrEmpty(_entry1) && !string.IsNullOrEmpty(_entry2) && !string.IsNullOrEmpty(_entry3) && !string.IsNullOrEmpty(_entry4) && !string.IsNullOrEmpty(_entry5);
                        break;
                    case 6:
                         validador = !string.IsNullOrEmpty(_entry1) && !string.IsNullOrEmpty(_entry2) && !string.IsNullOrEmpty(_entry3) && !string.IsNullOrEmpty(_entry4) && !string.IsNullOrEmpty(_entry5) && !string.IsNullOrEmpty(_entry6);
                        break;
                }
                return validador;
            });




        }

    }
}
