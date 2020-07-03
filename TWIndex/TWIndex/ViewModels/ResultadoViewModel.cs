using MVVMCoffee.ViewModels;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using TWIndex.Models;
using TWIndex.Services;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class ResultadoViewModel : BaseViewModel
    {

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private bool _show;
        public bool Show
        {
            get => _show;
            set => SetProperty(ref _show, value);
        }

        private Resultado _resultado;
        public Resultado Resultado
        {
            get => _resultado;
            set => SetProperty(ref _resultado, value);
        }

        public ICommand PushAsyncGraficoCommand { get; private set; }

        public ResultadoViewModel(List<string> palavras)
        {
            TitlePage = "Resultados";
            _ = ConsultaPytrends(palavras);

            PushAsyncGraficoCommand = new Command<string>(ExecutePushAsyncGraficoCommand);

        }

        private async void ExecutePushAsyncGraficoCommand(string palavra)
        {

            await Navigation.PushAsync<GraficoViewModel>(false, this.Resultado, palavra);
           
        }

        private async Task ConsultaPytrends(List<string> palavras)
        {

            Show = false;
            IsBusy = true;


            try
            {
                var Pytrends = RestService.For<IRestApi>(EndPoints.BaseUrl);
                var response = await Pytrends.Request(palavras);
                this.Resultado = response;

            }

            catch

            {
                string mensagem = "Erro de Conexão, tente novamente mais tarde!";
                MessagingCenter.Send(mensagem, "Erro");
            }

            finally
            {
                Show = true;
                IsBusy = false;

            }


        }


    }
}
