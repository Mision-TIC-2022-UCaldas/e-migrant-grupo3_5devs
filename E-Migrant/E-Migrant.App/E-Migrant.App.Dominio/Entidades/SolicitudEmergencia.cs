using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class SolicitudEmergencia
    {
        public int Id {get;set;}
        public string Descripcion {get;set;}
        public string Direccion {get;set;}
        public DateTime FechaSolicitud {get;set;}
        public TipoEmergencia tipoEmergencia {get;set;}
        public EstadoEmergencia estadoEmergencia {set;get;}
    }
}