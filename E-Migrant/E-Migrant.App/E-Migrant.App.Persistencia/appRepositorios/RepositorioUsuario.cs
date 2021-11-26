using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Referencia al contexto de Diagostico
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioUsuario (appContext appContext)
        {
            _appContext=appContext;
        }
        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioAdicionado= _appContext.Usuario.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        bool IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var UsuarioEncontrado= _appContext.Usuario.FirstOrDefault(m=>m.Id == idUsuario);
            if(UsuarioEncontrado==null)
                return false;
            _appContext.Usuario.Remove(UsuarioEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuario()
        {
            return _appContext.Usuario;
        }

        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuario.FirstOrDefault(m=>m.Id == idUsuario);
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = _appContext.Usuario.FirstOrDefault(m=>m.Id == usuario.Id);
            if (usuarioEncontrado!=null)
            {
                usuarioEncontrado.Username = usuario.Username;
                usuarioEncontrado.Password = usuario.Password;
                usuarioEncontrado.rol = usuario.rol;
                
                _appContext.SaveChanges();
            }
            return usuarioEncontrado;
        }
    }
}