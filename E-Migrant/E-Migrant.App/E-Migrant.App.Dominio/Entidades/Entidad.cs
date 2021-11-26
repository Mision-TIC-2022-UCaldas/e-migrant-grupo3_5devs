using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Entidad
    {
        public int Id {get;set;}
        [Required]
        public string RazonSocial {get;set;} 
        [Required]
        public string Nit {get;set;}
        [Required]
        public string Direccion {get;set;}
        [Required]
        public string Ciudad {get;set;}
        [Required]
        public string Telefono {get;set;}
        [Required]
        public Sector Sector {get;set;}
        [Required]
        public TipoServicio TipoServicio {get;set;}
        public string Email {get;set;}
        public string PaginaWeb {get;set;}


    }
}