using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TWIndex.Models
{
    public class Trabalho : INotifyPropertyChanged
    {
       
        public string Tipo {get; set;}


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {

                titulo = value;
                OnPropertyChanged(titulo);

            }
        }


        private string autor;
        public string Autor
        {
            get { return autor; }
            set
            {

                autor = value;
                OnPropertyChanged(autor);

            }
        }



        private string origem;
        public string Origem
        {
            get { return origem; }
            set
            {

                origem = value;
                OnPropertyChanged(origem);

            }
        }

        private string departamento;
        public string Departamento
        {
            get { return departamento; }
            set
            {
                departamento = value;
                OnPropertyChanged(departamento);

            }
        }

        public Trabalho()
        {
                
        }




    }
}
