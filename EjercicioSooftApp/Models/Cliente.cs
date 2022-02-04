using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EjercicioSooftApp.Models
{

    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [JsonProperty("idCliente")]
        public int Id { get; set; }


        [Column("nombre")]
        [JsonProperty("nombre")]
        public string Nombre { get; set; }


        [Column("apellido")]
        [JsonProperty("apellido")]
        public string Apellido { get; set; }


        [Column("telefono")]
        [JsonProperty("telefono")]
        public string Telefono { get; set; }

        [Column("email")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Column("direccion_id")]
        [JsonProperty("direccionId")]
        public int DireccionId { get; set; }

        [ForeignKey("DireccionId")]
        [JsonProperty("direccion")]
        public virtual Direccion Direccion { get; set; }

        [Column("tipo_cliente_id")]
        [JsonProperty("tipoClienteId")]
        public int TipoClienteId { get; set; }

        [ForeignKey("TipoClienteId")]
        [JsonProperty("tipoCliente")]
        public virtual TipoCliente TipoCliente { get; set; }


    }
}
