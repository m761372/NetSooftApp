using NetSooftApp.Models;
using System;
using System.Collections.Generic;


namespace EjercicioSooftApp.Models
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SooftAppContext>
    {
        protected override void Seed(SooftAppContext context)
        {
            var tiposCliente = new List<TipoCliente>
            {
                new TipoCliente{Descripcion="ClaseA"},
                new TipoCliente{Descripcion="ClaseB"},
            };

            tiposCliente.ForEach(s => context.TipoClientes.Add(s));
            context.SaveChanges();

            var direccionPais = new List<DireccionPais>
            {
                new DireccionPais{Nombre="Argentina"},
                new DireccionPais{Nombre="Uruguay"},
                new DireccionPais{Nombre="Chile"},
            };

            direccionPais.ForEach(s => context.DireccionPaises.Add(s));
            context.SaveChanges();

            var direcciones = new List<Direccion>
            {
                new Direccion{Altura=123,Calle="Av. Italia", DireccionPaisId=1, Localidad="CABA", Numero=234,Provincia="Buenos Aires"},
                new Direccion{Altura=565,Calle="San Nicolás", DireccionPaisId=1, Localidad="CABA", Numero=778,Provincia="Buenos Aires"},
                new Direccion{Altura=133,Calle="Carlos Gardel", DireccionPaisId=2, Localidad="Uruguay", Numero=455,Provincia="Montevideo"},
                new Direccion{Altura=444,Calle="Carlos Gardel2", DireccionPaisId=2, Localidad="Uruguay2", Numero=666,Provincia="Montevideo2"},
                new Direccion{Altura=5565,Calle="Concepción", DireccionPaisId=3, Localidad="Santiago Chile", Numero=333,Provincia="Santiago"},
            };

            direcciones.ForEach(s => context.Direcciones.Add(s));
            context.SaveChanges();


            var clientes = new List<Cliente>
            {
                new Cliente{Apellido="Carson",DireccionId=1,Email="mail1@gmail.com",Nombre="Juan",Telefono="1177777",TipoClienteId=1},
                new Cliente{Apellido="Gonzalez",DireccionId=1,Email="mail2@hotmail.com",Nombre="Maria",Telefono="1188888",TipoClienteId=2},
                new Cliente{Apellido="Rincón",DireccionId=2,Email="mail3@hotmail.com",Nombre="Samuel",Telefono="119999",TipoClienteId=1},
                new Cliente{Apellido="Pereyra",DireccionId=2,Email="mail4@outlook.com",Nombre="Javier",Telefono="110000",TipoClienteId=2},
                new Cliente{Apellido="Toledo",DireccionId=2,Email="mail5@yahoo.com",Nombre="Carla",Telefono="111111",TipoClienteId=2},
                new Cliente{Apellido="Pérez",DireccionId=3,Email="mail6@yahoo.com",Nombre="Victor",Telefono="98495489",TipoClienteId=2},

                new Cliente{Apellido="Gonzalez2",DireccionId=1,Email="mail7@hotmail.com",Nombre="Maria",Telefono="1188888",TipoClienteId=2},
                new Cliente{Apellido="Rincón2",DireccionId=4,Email="mail8@gmail.com",Nombre="Samuel",Telefono="119999",TipoClienteId=1},
                new Cliente{Apellido="Pereyra2",DireccionId=5,Email="mail9@outlook.com",Nombre="Javier",Telefono="110000",TipoClienteId=2},
                new Cliente{Apellido="Toledo2",DireccionId=5,Email="mail10@yahoo.com",Nombre="Carla",Telefono="111111",TipoClienteId=2},
            };

            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
            
        }
    }
}