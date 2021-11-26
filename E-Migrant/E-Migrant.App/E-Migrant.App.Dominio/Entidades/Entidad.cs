using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Entidad
    {
        public int Id {get;set;}
        [Required]
        public String RazonSocial {get;set;} 
        [Required]
        public String Nit {get;set;}
        [Required]
        public String Direccion {get;set;}
        [Required]
        public String Ciudad {get;set;}
        [Required]
        public String Telefono {get;set;}
        [Required]
        public Sector Sector {get;set;}
        [Required]
        public TipoServicio TipoServicio {get;set;}
        public String Email {get;set;}
        public String PaginaWeb {get;set;}


    }
}