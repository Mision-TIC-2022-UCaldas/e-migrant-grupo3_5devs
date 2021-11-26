using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Migrante
    {
        public int Id {get;set;}
        [Required]
        public string Nombre {get;set;} 
        [Required]
        public string Apellidos {get;set;}
        [Required]
        public TipoDocumento tipoDocumento {get;set;}
        [Required]
        public string NumeroDocumento {get;set;}
        [Required]
        public string PaisOrigen {get;set;}
        [Required]
        public DateTime FechaNacimiento {get;set;}
        public string Email {get;set;}
        public string Telefono {get;set;}
        public string Direccion {get;set;}
        public string Ciudad {get;set;}
        public string SituacionLaboral {get;set;}

        //Relaciones 
        //Enmigrante solicita servicio
        public SolicitudSerivicio solicitudServicio {get;set;}
        //Familiares y Amigos
        public System.Collections.Generic.List<Migrante> Amigos { get; set; }
        public System.Collections.Generic.List<Migrante> Familiares { get; set; }

    }
}