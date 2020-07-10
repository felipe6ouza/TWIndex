using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficoPage : ContentPage
    {
        public static readonly SKColor TextColor = SKColors.Black;

        public GraficoPage()
        {
            InitializeComponent();

            InicialiazarGrafico();

        }

        private void InicialiazarGrafico()
        {
            MessagingCenter.Subscribe<Dictionary<string, float>>(this, "dados", (msg) =>
            {

                var chart = PopularDados(msg);
                this.LineChart.Chart = chart[0];

            });
        }

        public Chart[] PopularDados(Dictionary<string, float> Dados)
        {
            var meses = new Dictionary<string, int>();
            #region AdicionarMeses
            meses.Add("Janeiro", 1);
            meses.Add("Fevereiro", 2);
            meses.Add("Março", 3);
            meses.Add("Abril", 4);
            meses.Add("Maio", 5);
            meses.Add("Junho", 6);
            meses.Add("Julho", 7);
            meses.Add("Agosto", 8);
            meses.Add("Setembro", 9);
            meses.Add("Outubro", 10);
            meses.Add("Novembro", 11);
            meses.Add("Dezembro", 12);
            #endregion
            var mesesOrdenados = new List<string>();

            var atual = DateTime.Now.Month;

            for (int i = atual - 1; i >= 1; i--)
                mesesOrdenados.Add(meses.Where(a => a.Value == i).Select(a => a.Key).First());

            for (int i = 12; i >= atual; i--)
                mesesOrdenados.Add(meses.Where(a => a.Value == i).Select(a => a.Key).First());

            mesesOrdenados.Reverse();

            var entries = new[]
            {
                new ChartEntry(Dados[mesesOrdenados[0]])
                {
                    Label = mesesOrdenados[0],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[0]]),

                    Color = SKColor.Parse("#266488"),
                    TextColor = TextColor
                },

                 new ChartEntry(Dados[mesesOrdenados[1]])
                {
                    Label = mesesOrdenados[1],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[1]]),
                    Color = SKColor.Parse("#68b9c0"),
                    TextColor = TextColor
                },
                 new ChartEntry(Dados[mesesOrdenados[2]])
                {
                    Label = mesesOrdenados[2],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[2]]),
                    Color = SKColor.Parse("#90d585"),
                    TextColor = TextColor
                }, 
                
                new ChartEntry(Dados[mesesOrdenados[3]])
                {
                    Label = mesesOrdenados[3],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[3]]),
                    Color = SKColor.Parse("#f3c151"),
                    TextColor = TextColor
                }, 
                new ChartEntry(Dados[mesesOrdenados[4]])
                {
                    Label = mesesOrdenados[4],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[4]]),
                    Color = SKColor.Parse("#f37f64"),
                    TextColor = TextColor

                },
                
                new ChartEntry(Dados[mesesOrdenados[5]])
                {
                    Label = mesesOrdenados[5],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[5]]),
                    Color = SKColor.Parse("#424856"),
                    TextColor = TextColor
                },
                   
                new ChartEntry(Dados[mesesOrdenados[6]])
                {
                    Label = mesesOrdenados[6],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[6]]),
                    Color = SKColor.Parse("#8f97a4"),
                    TextColor = TextColor
                },   
                
                new ChartEntry(Dados[mesesOrdenados[7]])
                {
                    Label = mesesOrdenados[7],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[7]]),
                    Color = SKColor.Parse("#dabf96"),
                    TextColor = TextColor
                },
                  
                new ChartEntry(Dados[mesesOrdenados[8]])
                {
                    Label = mesesOrdenados[8],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[8]]),
                    Color = SKColor.Parse("#76846e"),
                    TextColor = TextColor
                },
                   
                new ChartEntry(Dados[mesesOrdenados[9]])
                {
                    Label = mesesOrdenados[9],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[9]]),
                    Color = SKColor.Parse("#dabfaf"),
                    TextColor = TextColor
                },

                  
                new ChartEntry(Dados[mesesOrdenados[10]])
                {
                    Label = mesesOrdenados[10],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[10]]),
                    Color = SKColor.Parse("#a65b69"),
                    TextColor = TextColor
                },
                   
                new ChartEntry(Dados[mesesOrdenados[11]])
                {
                    Label = mesesOrdenados[11],
                    ValueLabel = string.Format("{0:N2}", Dados[mesesOrdenados[11]]),
                    Color = SKColor.Parse("#97a69d"),
                    TextColor = TextColor
                },

               

        };

            return new Chart[]
            {
                new LineChart()
                {
                    Entries = entries,
                    LineMode = LineMode.Straight,
                    LineSize = 6,
                    PointMode = PointMode.Square,
                    PointSize = 24,
                    LabelTextSize = 32,
                    Margin = 30
                }
            };

        }
    }
}