using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioNovedad
    {
        IEnumerable<Novedad> GetAllNovedad();

        // Añadir
        Novedad AddNovedad(Novedad novedad);

        // Actualizar
        Novedad UpdateNovedad(Novedad novedad);

        // Borrar
        bool DeleteNovedad(int idNovedad);

        // ver
        Novedad GetNovedad(int idNovedad);
    }
}