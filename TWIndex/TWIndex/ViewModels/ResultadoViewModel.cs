using MVVMCoffee.ViewModels;
using Refit;
using System;
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

        public ICommand PushAsyncGraficoPalavraCommand { get; private set; }

        public ICommand PushAsyncGraficoConjuntoCommand { get; private set; }


        public ResultadoViewModel(List<string> palavras)
        {
            var palavrasFiltradas = new List<string>();

            foreach (var item in palavras)
            {
                if (!string.IsNullOrEmpty(item))
                    palavrasFiltradas.Add(item);
            }


            ConsultaPytrends(palavrasFiltradas);

            PushAsyncGraficoPalavraCommand = new Command<string>(ExecutePushAsyncCommand);
            PushAsyncGraficoConjuntoCommand = new Command(ExecutePushAsyncGraficoConjunto);


        }

        private async void ExecutePushAsyncGraficoConjunto()
        {
            await Navigation.PushAsync<GraficoViewModel>(false, Resultado);
        }

        private async void ExecutePushAsyncCommand(string palavra)
        {

            await Navigation.PushAsync<GraficoViewModel>(false, Resultado, palavra);
           
        }

        private async void ConsultaPytrends(List<string> palavras)
        {

            Show = false;
            IsBusy = true;


            try
            {
                var Pytrends = RestService.For<IRestApi>(EndPoints.BaseUrl);
                var response = await Pytrends.Request(palavras);
                Resultado = response;

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
