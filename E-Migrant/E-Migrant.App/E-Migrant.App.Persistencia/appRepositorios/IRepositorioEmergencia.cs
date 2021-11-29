using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioEmergencia
    {
        IEnumerable<Emergencia> GetAllEmergencia();

        // Añadir
        Emergencia AddEmergencia(Emergencia emergencia);

        // Actualizar
        Emergencia UpdateEmergencia(Emergencia emergencia);

        // Borrar
        bool DeleteEmergencia(int idEmergencia);

        // ver
        Emergencia GetEmergencia(int idEmergencia);

        // Busqueda por Filtro
        Emergencia SearchFilter(int searchString);

    }
}