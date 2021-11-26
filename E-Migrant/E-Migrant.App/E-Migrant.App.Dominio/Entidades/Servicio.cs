using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Servicio
    {
        public int Id {get;set;}
        public TipoServicio tipoServicio {get;set;}
        public Entidad Entidad {get;set;}
        public int Cupo {get;set;}
        public DateTime FechaInicio {get;set;}
        public DateTime FechaFinal {get;set;}
        public EstadoServicio EstadoServicio {get;set;}

        //Evaluaciones
        public System.Collections.Generic.List<EvaluacionServicio> Evaluaciones { get; set; }
    }
}