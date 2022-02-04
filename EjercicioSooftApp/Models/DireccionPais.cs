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
    public class DireccionPais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Column("nombre")]
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

    }
}
