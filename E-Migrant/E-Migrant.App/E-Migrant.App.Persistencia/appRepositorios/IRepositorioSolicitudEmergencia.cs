using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioSolicitudEmergencia
    {
        IEnumerable<SolicitudEmergencia> GetAllSolicitudEmergencia();

        // Añadir
        SolicitudEmergencia AddSolicitudEmergencia(SolicitudEmergencia SolicitudEmergencia);

        // Actualizar
        SolicitudEmergencia UpdateSolicitudEmergencia(SolicitudEmergencia SolicitudEmergencia);

        // Borrar
        bool DeleteSolicitudEmergencia(int idSolicitudEmergencia);

        // ver
        SolicitudEmergencia GetSolicitudEmergencia(int idSolicitudEmergencia);
    }
}