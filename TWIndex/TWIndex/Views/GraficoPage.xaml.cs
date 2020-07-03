using Microcharts;
using SkiaSharp;
using System.Collections.Generic;
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
            var entries = new[]
            {
                new ChartEntry(Dados["Janeiro"])
                {
                    Label = "Janeiro",
                    ValueLabel = string.Format("{0:N2}", Dados["Janeiro"]),

                    Color = SKColor.Parse("#266488"),
                    TextColor = TextColor
                },

                 new ChartEntry(Dados["Fevereiro"])
                {
                    Label = "Fevereiro",
                    ValueLabel = string.Format("{0:N2}", Dados["Fevereiro"]),
                    Color = SKColor.Parse("#68b9c0"),
                    TextColor = TextColor
                },
                 new ChartEntry(Dados["Março"])
                {
                    Label = "Março",
                    ValueLabel = string.Format("{0:N2}", Dados["Março"]),
                    Color = SKColor.Parse("#90d585"),
                    TextColor = TextColor
                },

                new ChartEntry(Dados["Abril"])
                {
                    Label = "Abril",
                    ValueLabel = string.Format("{0:N2}", Dados["Abril"]),
                    Color = SKColor.Parse("#f3c151"),
                    TextColor = TextColor
                },

                new ChartEntry(Dados["Maio"])
                {
                    Label = "Maio",
                    ValueLabel = string.Format("{0:N2}", Dados["Maio"]),
                    Color = SKColor.Parse("#f37f64"),
                    TextColor = TextColor
                },
                 new ChartEntry(Dados["Junho"])
                {
                    Label = "Junho",
                    ValueLabel = string.Format("{0:N2}", Dados["Junho"]),
                    Color = SKColor.Parse("#424856"),
                    TextColor = TextColor
                },
                 new ChartEntry(Dados["Julho"])
                {
                    Label = "Julho",
                    ValueLabel = string.Format("{0:N2}", Dados["Julho"]),
                    Color = SKColor.Parse("#8f97a4"),
                    TextColor = TextColor
                },

                 new ChartEntry(Dados["Agosto"])
                {
                    Label = "Agosto",
                    ValueLabel = string.Format("{0:N2}", Dados["Agosto"]),
                    Color = SKColor.Parse("#dabf96"),
                    TextColor = TextColor
                },

                  new ChartEntry(Dados["Setembro"])
                {
                    Label = "Setembro",
                    ValueLabel = string.Format("{0:N2}", Dados["Setembro"]),
                    Color = SKColor.Parse("#76846e"),
                    TextColor = TextColor
                },

                  new ChartEntry(Dados["Outubro"])
                {
                    Label = "Outubro",
                    ValueLabel = string.Format("{0:N2}", Dados["Outubro"]),
                    Color = SKColor.Parse("#dabfaf"),
                    TextColor = TextColor
                },


                  new ChartEntry(Dados["Novembro"])
                {
                    Label = "Novembro",
                    ValueLabel = string.Format("{0:N2}", Dados["Novembro"]),
                    Color = SKColor.Parse("#a65b69"),
                    TextColor = TextColor
                },


                  new ChartEntry(Dados["Dezembro"])
                {
                    Label = "Dezembro",
                    ValueLabel = string.Format("{0:N2}", Dados["Dezembro"]),
                    Color = SKColor.Parse("#97a69d"),
                    TextColor = TextColor
                }

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
                },
                 new BarChart()
                {
                  Entries = entries ,
                  LabelTextSize = 35
                },
                new PointChart()
                {
                  Entries = entries ,
                  LabelTextSize = 35
                },
            };

        }
    }
}