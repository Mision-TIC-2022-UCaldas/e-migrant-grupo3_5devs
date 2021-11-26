using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class SolicitudSerivicio
    {
        public int Id {get;set;}
        public Servicio Servicio {get;set;}
        public String Descripcion {get;set;}
        public NivelPrioridad nivelPrioridad {get;set;}
        public DateTime FechaSolicitud {get;set;}
        public DateTime FechaAceptacionSolicitud {get;set;}
        public EstadoSolicitud estadoSolicitud {get;set;}
        public Entidad Entidad {get;set;}
        
        public EvaluacionServicio Evaluacion {get;set;}

    }
}