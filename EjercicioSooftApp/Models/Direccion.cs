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
    public class Direccion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Column("calle")]
        [JsonProperty("calle")]
        public string Calle { get; set; }

        [Column("numero")]
        [JsonProperty("numero")]
        public int Numero { get; set; }

        [Column("altura")]
        [JsonProperty("altura")]

        public int Altura { get; set; }

        [Column("localidad")]
        [JsonProperty("localidad")]
        public string Localidad { get; set; }

        [Column("provincia")]
        [JsonProperty("provincia")]
        public string Provincia { get; set; }

        [Column("direccion_pais_id")]
        [JsonProperty("direccionPaisId")]
        public int DireccionPaisId { get; set; }

        [ForeignKey("DireccionPaisId")]
        [JsonProperty("direccionPais")]
        public virtual DireccionPais DireccionPais { get; set; }

    }
}
