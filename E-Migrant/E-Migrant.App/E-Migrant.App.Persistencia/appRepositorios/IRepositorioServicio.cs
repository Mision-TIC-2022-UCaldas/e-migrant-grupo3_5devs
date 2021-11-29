using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioServicio
    {
        IEnumerable<Servicio> GetAllServicio();

        // Añadir
        Servicio AddServicio(Servicio servicio);

        // Actualizar
        Servicio UpdateServicio(Servicio servicio);

        // Borrar
        bool DeleteServicio(int idServicio);

        // ver
        Servicio GetServicio(int idServicio);
        IEnumerable<Servicio> GetServiciosEntidad(Entidad entidad);
    }
}