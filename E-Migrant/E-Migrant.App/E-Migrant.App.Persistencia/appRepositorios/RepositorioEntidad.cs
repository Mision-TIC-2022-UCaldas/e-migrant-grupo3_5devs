using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioEntidad : IRepositorioEntidad
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
        public RepositorioEntidad (appContext appContext)
        {
            _appContext=appContext;
        }

        public Entidad SearchFilter(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return _appContext.Entidad.FirstOrDefault(m => m.RazonSocial == searchString);
            }
            return null;
        }

        Entidad IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
            var nitEncontrado = _appContext.Entidad.FirstOrDefault(m=>m.Nit == entidad.Nit);
            if (nitEncontrado == null)
            {    
                var entidadAdicionada= _appContext.Entidad.Add(entidad);
                _appContext.SaveChanges();
                return entidadAdicionada.Entity;
            }
            return null;
        }

        bool IRepositorioEntidad.DeleteEntidad(int idEntidad)
        {
            var EntidadEncontrada= _appContext.Entidad.FirstOrDefault(m=>m.Id == idEntidad);
            if(EntidadEncontrada==null)
                return false;
            _appContext.Entidad.Remove(EntidadEncontrada);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Entidad> IRepositorioEntidad.GetAllEntidad()
        {
            return _appContext.Entidad;
        }

        Entidad IRepositorioEntidad.GetEntidad(int idEntidad)
        {
            return _appContext.Entidad.FirstOrDefault(m=>m.Id == idEntidad);
        }

        Entidad IRepositorioEntidad.UpdateEntidad(Entidad entidad)
        {
            var entidadEncontrada = _appContext.Entidad.FirstOrDefault(m=>m.Id == entidad.Id);
            if (entidadEncontrada!=null)
            {
                entidadEncontrada.RazonSocial = entidad.RazonSocial;
                entidadEncontrada.Nit = entidad.Nit;
                entidadEncontrada.Direccion = entidad.Direccion;
                entidadEncontrada.Ciudad = entidad.Ciudad;
                entidadEncontrada.Telefono = entidad.Telefono;
                entidadEncontrada.Sector = entidad.Sector;
                entidadEncontrada.TipoServicio = entidad.TipoServicio;
                entidadEncontrada.Email = entidad.Email;
                entidadEncontrada.PaginaWeb = entidad.PaginaWeb;
                entidadEncontrada.evaluacionGerencia = entidad.evaluacionGerencia;
                
                _appContext.SaveChanges();
            }
            return entidadEncontrada;
        }
    }
}