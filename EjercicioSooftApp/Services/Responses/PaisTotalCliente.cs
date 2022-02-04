using Newtonsoft.Json;


namespace EjercicioSooftApp.Services.Responses
{
    public class PaisTotalCliente
    {
        [JsonProperty("codigoPais")]
        public int CodigoPais { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("cantidadClientes")]
        public long CantidadClientes { get; set; }
    }
}