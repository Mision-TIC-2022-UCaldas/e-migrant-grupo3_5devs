using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioMensaje : IRepositorioMensaje
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
        public RepositorioMensaje (appContext appContext)
        {
            _appContext=appContext;
        }
        Mensaje IRepositorioMensaje.AddMensaje(Mensaje mensaje)
        {
            var mensajeAdicionado= _appContext.Mensaje.Add(mensaje);
            _appContext.SaveChanges();
            return mensajeAdicionado.Entity;
        }

        bool IRepositorioMensaje.DeleteMensaje(int idMensaje)
        {
            var MensajeEncontrado= _appContext.Mensaje.FirstOrDefault(m=>m.Id == idMensaje);
            if(MensajeEncontrado==null)
                return false;
            _appContext.Mensaje.Remove(MensajeEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Mensaje> IRepositorioMensaje.GetAllMensaje()
        {
            return _appContext.Mensaje;
        }

        Mensaje IRepositorioMensaje.GetMensaje(int idMensaje)
        {
            return _appContext.Mensaje.FirstOrDefault(m=>m.Id == idMensaje);
        }

        Mensaje IRepositorioMensaje.UpdateMensaje(Mensaje mensaje)
        {
            var mensajeEncontrado = _appContext.Mensaje.FirstOrDefault(m=>m.Id == mensaje.Id);
            if (mensajeEncontrado!=null)
            {
                mensajeEncontrado.EstadoMensaje = mensaje.EstadoMensaje;
                mensajeEncontrado.Contenido = mensaje.Contenido;
                mensajeEncontrado.Emisor = mensaje.Emisor;
                mensajeEncontrado.Receptor = mensaje.Receptor;
                
                _appContext.SaveChanges();
            }
            return mensajeEncontrado;
        }
    }
}