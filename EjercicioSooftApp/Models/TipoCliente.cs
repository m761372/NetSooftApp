using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSooftApp.Models
{
    public class TipoCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Column("descripcion")]
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }
}
