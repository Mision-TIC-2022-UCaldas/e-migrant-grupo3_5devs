using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioNecesidad
    {
        IEnumerable<Necesidad> GetAllNecesidad();

        // Añadir
        Necesidad AddNecesidad(Necesidad necesidad);

        // Actualizar
        Necesidad UpdateNecesidad(Necesidad necesidad);

        // Borrar
        bool DeleteNecesidad(int idNecesidad);

        // ver
        Necesidad GetNecesidad(int idNecesidad);

        // Busqueda por Filtro
        Necesidad SearchFilter(int searchString);

    }
}