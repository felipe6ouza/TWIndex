using MVVMCoffee.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TWIndex.Models
{
    public partial class Resultado : BaseModel
    {
        [JsonProperty("desempenho-anual-palavra")]
        public Dictionary<string, float> DesempenhoAnualPalavra { get; set; }

        [JsonProperty("desempenho-mensal-palavra")]
        public Dictionary<string, Dictionary<string, float>> DesempenhoMensalPalavra { get; set; }

        [JsonProperty("desempenho-mensal-conjunto")]
        public Dictionary<string, float> DesempenhoMensalConjunto { get; set; }

    }
}
