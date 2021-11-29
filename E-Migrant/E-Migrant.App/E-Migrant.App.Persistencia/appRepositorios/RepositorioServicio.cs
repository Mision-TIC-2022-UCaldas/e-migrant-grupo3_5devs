using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioServicio : IRepositorioServicio
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
        public RepositorioServicio (appContext appContext)
        {
            _appContext=appContext;
        }
        Servicio IRepositorioServicio.AddServicio(Servicio servicio)
        {
            var servicioAdicionado= _appContext.Servicio.Add(servicio);
            _appContext.SaveChanges();
            return servicioAdicionado.Entity;
        }

        bool IRepositorioServicio.DeleteServicio(int idServicio)
        {
            var ServicioEncontrado= _appContext.Servicio.FirstOrDefault(m=>m.Id == idServicio);
            if(ServicioEncontrado==null)
                return false;
            _appContext.Servicio.Remove(ServicioEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Servicio> IRepositorioServicio.GetAllServicio()
        {
            return _appContext.Servicio;
        }

        IEnumerable<Servicio> IRepositorioServicio.GetServiciosEntidad(Entidad entidad)
        {
            //var = _appContext.Servicio;
            return _appContext.Servicio.Where(m=>m.Entidad == entidad);
            /*foreach (var item in _appContext.Servicio)
            {
                item.Equals
                _appContext.Servicio.FirstOrDefault(m=>m.Id == idServicio)
            }
            //return _appContext.Servicio.Where(m=>m.EntidadId == idEntidad);
            _appContext*/
        }

        Servicio IRepositorioServicio.GetServicio(int idServicio)
        {
            return _appContext.Servicio.FirstOrDefault(m=>m.Id == idServicio);
        }

        Servicio IRepositorioServicio.UpdateServicio(Servicio servicio)
        {
            var servicioEncontrado = _appContext.Servicio.FirstOrDefault(m=>m.Id == servicio.Id);
            if (servicioEncontrado!=null)
            {
                servicioEncontrado.NombreServicio = servicio.NombreServicio;
                servicioEncontrado.Entidad = servicio.Entidad;
                servicioEncontrado.TipoServicio = servicio.TipoServicio;
                servicioEncontrado.Cupo = servicio.Cupo;
                servicioEncontrado.FechaInicio = servicio.FechaInicio;
                servicioEncontrado.FechaFinal = servicio.FechaFinal;
                servicioEncontrado.EstadoServicio = servicio.EstadoServicio;
                servicioEncontrado.Activo = servicio.Activo;
                
                _appContext.SaveChanges();
            }
            return servicioEncontrado;
        }
    }
}