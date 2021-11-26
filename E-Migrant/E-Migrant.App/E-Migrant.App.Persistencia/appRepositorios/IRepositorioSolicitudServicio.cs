using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioSolicitudServicio
    {
        IEnumerable<SolicitudServicio> GetAllSolicitudServicio();

        // Añadir
        SolicitudServicio AddSolicitudServicio(SolicitudServicio solicitudservicio);

        // Actualizar
        SolicitudServicio UpdateSolicitudServicio(SolicitudServicio solicitudservicio);

        // Borrar
        bool DeleteSolicitudServicio(int idSolicitudServicio);

        // ver
        SolicitudServicio GetSolicitudServicio(int idSolicitudServicio);
    }
}