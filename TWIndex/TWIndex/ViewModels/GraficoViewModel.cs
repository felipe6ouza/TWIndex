using MVVMCoffee.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using TWIndex.Models;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class GraficoViewModel : BaseViewModel
    {
        private Resultado _resultado;

        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public Resultado Resultado
        {
            get => _resultado;
            set => SetProperty(ref _resultado, value);
        }
        public GraficoViewModel(Resultado resultado)
        {
            Resultado = resultado;
            Titulo = "Conjunto de todas as palavras-chave";
            Subtitulo = "Desempenho do conjunto por mês ao longo do último ano";
            DesempenhoConjunto();
        }

        private void DesempenhoConjunto()
        {
            var resultadoFiltrado = new Dictionary<string, float>();
            resultadoFiltrado = Resultado.DesempenhoMensalConjunto;
            MessagingCenter.Send(resultadoFiltrado, "dados");
        }

        public GraficoViewModel(Resultado resultado, string palavrachave)
        {
            Resultado = resultado;
            Titulo = palavrachave;
            Subtitulo = "Desempenho da palavra-chave por mês ao longo do último ano";
            DesempenhoMensalPalavra(palavrachave);

        }

        private void DesempenhoMensalPalavra(string palavra)
        {
            var resultadoFiltrado = new Dictionary<string, float>();
            resultadoFiltrado = Resultado.DesempenhoMensalPalavra[palavra];
            MessagingCenter.Send(resultadoFiltrado, "dados");
        }
    }
}
