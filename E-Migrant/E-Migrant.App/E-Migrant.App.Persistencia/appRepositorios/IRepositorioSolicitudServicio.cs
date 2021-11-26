using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioSolicitudServicio
    {
        IEnumerable<SolicitudSerivicio> GetAllSolicitudServicio();

        // Añadir
        SolicitudSerivicio AddSolicitudServicio(SolicitudSerivicio solicitudservicio);

        // Actualizar
        SolicitudSerivicio UpdateSolicitudServicio(SolicitudSerivicio solicitudservicio);

        // Borrar
        bool DeleteSolicitudServicio(int idSolicitudServicio);

        // ver
        SolicitudSerivicio GetSolicitudServicio(int idSolicitudServicio);
    }
}