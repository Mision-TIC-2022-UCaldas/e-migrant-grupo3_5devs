using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class SolicitudServicio
    {
        public int Id {get;set;}
        public Servicio Servicio {get;set;}
        public string Descripcion {get;set;}
        public NivelPrioridad nivelPrioridad {get;set;}
        public DateTime FechaSolicitud {get;set;}
        public DateTime FechaAceptacionSolicitud {get;set;}
        public EstadoSolicitud estadoSolicitud {get;set;}
        public Entidad Entidad {get;set;}
        public Migrante migrante {get;set;}
        
        public EvaluacionServicio Evaluacion {get;set;}
        public EvaluacionServicio ComportamientoMigrante {get;set;}

        //Tendríamos que agregar al migrante en la relación?

    }
}