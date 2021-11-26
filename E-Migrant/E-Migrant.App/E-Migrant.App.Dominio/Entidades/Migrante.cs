using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Migrante
    {
        public int Id {get;set;}
        [Required]
        public String Nombre {get;set;} 
        [Required]
        public String Apellidos {get;set;}
        [Required]
        public TipoDocumento tipoDocumento {get;set;}
        [Required]
        public String NumeroDocumento {get;set;}
        [Required]
        public String PaisOrigen {get;set;}
        [Required]
        public Date FechaNacimiento {get;set;}
        public String Email {get;set;}
        public String Telefono {get;set;}
        public String Direccion {get;set;}
        public String Ciudad {get;set;}
        public String SituacionLaboral {get;set;}

        //Relaciones 
        //Enmigrante solicita servicio
        public SolicitudSerivicio solicitudServicio {get;set;}
        //Familiares y Amigos
        public System.Collections.Generic.List<Migrante> Amigos { get; set; }
        public System.Collections.Generic.List<Migrante> Familiares { get; set; }

    }
}