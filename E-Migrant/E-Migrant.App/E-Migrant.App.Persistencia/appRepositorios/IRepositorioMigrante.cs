using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioMigrante
    {
        IEnumerable<Migrante> GetAllMigrante();

        // Añadir
        Migrante AddMigrante(Migrante migrante);

        // Actualizar
        Migrante UpdateMigrante(Migrante migrante);

        // Borrar
        bool DeleteMigrante(int idMigrante);

        // ver
        Migrante GetMigrante(int idMigrante);
    }
}