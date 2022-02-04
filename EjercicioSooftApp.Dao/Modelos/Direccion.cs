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
    public class Direccion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "calle")]
        public string Calle { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "numero")]
        public int Numero { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "altura")]
        public int Altura { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "localidad")]
        public string Localidad { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "provincia")]
        public string Provincia { get; set; }

        [Column(TypeName = "varchar(60)")]
        [JsonProperty(PropertyName = "direccion_pais_id")]
        public string DireccionPaisId { get; set; }

    }
}
