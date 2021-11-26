using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Entidad
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "La razón social es obligatoria.")]
        public string RazonSocial {get;set;} 
        [Required (ErrorMessage = "El NIT es obligatorio.")]
        public string Nit {get;set;}
        [Required (ErrorMessage = "La Dirección es obligatoria.")]
        public string Direccion {get;set;}
        [Required (ErrorMessage = "La Ciudad es obligatoria.")]
        public string Ciudad {get;set;}
        [Required (ErrorMessage = "El Telefono es obligatorio.")]
        public string Telefono {get;set;}
        [Required (ErrorMessage = "El Sector es obligatorio.")]
        public Sector Sector {get;set;}
        [Required (ErrorMessage = "El Tipo de Servicio es obligatorio.")]
        public TipoServicio TipoServicio {get;set;}
        public string Email {get;set;}
        public string PaginaWeb {get;set;}
        public EvaluacionServicio evaluacionGerencia {get;set;}

    }
}