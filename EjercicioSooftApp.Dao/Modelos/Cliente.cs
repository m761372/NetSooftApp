using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSooftApp.Dao.Modelos
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "apellido")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "telefono")]
        public string Telefono { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "direccion_id")]
        public int DireccionId { get; set; }

        [JsonProperty(PropertyName = "timpo_cliente_id")]
        public int TipoClienteId { get; set; }

    }
}
