using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioEntidad
    {
        IEnumerable<Entidad> GetAllEntidad();

        // Añadir
        Entidad AddEntidad(Entidad Entidad);

        // Actualizar
        Entidad UpdateEntidad(Entidad Entidad);

        // Borrar
        bool DeleteEntidad(int idEntidad);

        // ver
        Entidad GetEntidad(int idEntidad);
        
        //Busqueda por filtro
        Entidad SearchFilter(String searchString);
        //Busqueda por correo
        Entidad SearchEmail(string email);
    }
}