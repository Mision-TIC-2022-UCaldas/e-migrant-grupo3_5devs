using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Migrante
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "El Nombre es obligatorio.")]
        public string Nombre {get;set;} 
        [Required (ErrorMessage = "Los Apellidos son obligatorios.")]
        public string Apellidos {get;set;}
        [Required (ErrorMessage = "El Tipo de Documento es obligatorio.")]
        public TipoDocumento tipoDocumento {get;set;}
        [Required (ErrorMessage = "El Numero de Documento es obligatorio.")]
        public string NumeroDocumento {get;set;}
        [Required (ErrorMessage = "El País de Origen es obligatorio.")]
        public string PaisOrigen {get;set;}
        [Required (ErrorMessage = "La Fecha de Nacimiento es obligatoria.")]
        public DateTime FechaNacimiento {get;set;}
        public string Email {get;set;}
        public string Telefono {get;set;}
        public string Direccion {get;set;}
        public string Ciudad {get;set;}
        public string SituacionLaboral {get;set;}

        public Relacion Relacion {get; set;}
        //Relaciones 
        public System.Collections.Generic.List<Migrante> GrupoSocial { get; set; }
        
        //public ICollection<Migrante> Familiares { get; set; }
        //Enmigrante solicita servicio
        //public SolicitudSerivicio solicitudServicio {get;set;}
        //Familiares y Amigos
        //public System.Collections.Generic.List<Migrante> Amigos { get; set; }
        //public System.Collections.Generic.List<Migrante> Familiares { get; set; }
        //public System.Collections.Generic.List<string> Necesidades { get; set; }
    }
}