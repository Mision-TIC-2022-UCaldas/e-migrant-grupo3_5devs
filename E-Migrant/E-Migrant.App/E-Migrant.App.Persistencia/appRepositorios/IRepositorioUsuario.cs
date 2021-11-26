using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuario();

        // Añadir
        Usuario AddUsuario(Usuario usuario);

        // Actualizar
        Usuario UpdateUsuario(Usuario usuario);

        // Borrar
        bool DeleteUsuario(int idUsuario);

        // ver
        Usuario GetUsuario(int idUsuario);
    }
}