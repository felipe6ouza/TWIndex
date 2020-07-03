using MVVMCoffee.ViewModels;
using System.Collections.Generic;
using TWIndex.Models;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class GraficoViewModel : BaseViewModel
    {
        private Resultado _resultado;

        public string PalavraChave { get; set; }

        public Resultado Resultado
        {
            get => _resultado;
            set => SetProperty(ref _resultado, value);
        }
        public GraficoViewModel(Resultado resultado, string palavrachave)
        {
            Resultado = resultado;
            PalavraChave = palavrachave;
            FiltrarInformacoes();
        }

        private void FiltrarInformacoes()
        {
            Dictionary<string, float> resultadoFiltrado = new Dictionary<string, float>();
            resultadoFiltrado = Resultado.DesempenhoMensalPalavra[PalavraChave];
            MessagingCenter.Send<Dictionary<string, float>>(resultadoFiltrado, "dados");
        }
    }
}
