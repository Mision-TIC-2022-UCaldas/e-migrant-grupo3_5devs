using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioMensajes
    {
        IEnumerable<Mensaje> GetAllMensaje();

        // Añadir
        Mensaje AddMensaje(Mensaje mensaje);

        // Actualizar
        Mensaje UpdateMensaje(Mensaje mensaje);

        // Borrar
        bool DeleteMensaje(int idMensaje);

        // ver
        Mensaje GetMensaje(int idMensaje);
    }
}