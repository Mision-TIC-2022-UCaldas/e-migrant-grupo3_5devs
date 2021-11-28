using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Servicio
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "El Tipo de servicio es obligatoria.")]
        public string NombreServicio {get;set;}
        public Entidad Entidad {get;set;}
        [Range(1, 9999, ErrorMessage = "El valor debe estar {1} entre {2}")]
        public int Cupo {get;set;}
        [Range(typeof(DateTime), "1/1/2021", "31/12/2100", ErrorMessage = "La fecha debe estar {1} entre {2}")]
        public DateTime FechaInicio {get;set;}
        [Range(typeof(DateTime), "1/1/2021", "31/12/2100", ErrorMessage = "La fecha debe ser {1} entre {2}")]
        public DateTime FechaFinal {get;set;}
        [Required (ErrorMessage = "El estado es obligatorio.")]
        public EstadoServicio EstadoServicio {get;set;}
        public bool Activo {get;set;}

        //Evaluaciones
        //public System.Collections.Generic.List<EvaluacionServicio> Evaluaciones { get; set; }
    }
}