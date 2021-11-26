using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioSolicitudServicio : IRepositorioSolicitudServicio
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
        public RepositorioSolicitudServicio (appContext appContext)
        {
            _appContext=appContext;
        }

        SolicitudSerivicio IRepositorioSolicitudServicio.AddSolicitudServicio(SolicitudSerivicio solicitudservicio)
        {
            var solicitudservicioAdicionado= _appContext.SolicitudServicio.Add(solicitudservicio);
            _appContext.SaveChanges();
            return solicitudservicioAdicionado.Entity;
        }

        bool IRepositorioSolicitudServicio.DeleteSolicitudServicio(int idSolicitudServicio)
        {
            var SolicitudServicioEncontrado= _appContext.SolicitudServicio.FirstOrDefault(m=>m.Id == idSolicitudServicio);
            if(SolicitudServicioEncontrado==null)
                return false;
            _appContext.SolicitudServicio.Remove(SolicitudServicioEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<SolicitudSerivicio> IRepositorioSolicitudServicio.GetAllSolicitudServicio()
        {
            return _appContext.SolicitudServicio;
        }

        SolicitudSerivicio IRepositorioSolicitudServicio.GetSolicitudServicio(int idSolicitudServicio)
        {
            return _appContext.SolicitudServicio.FirstOrDefault(m=>m.Id == idSolicitudServicio);
        }

        SolicitudSerivicio IRepositorioSolicitudServicio.UpdateSolicitudServicio(SolicitudSerivicio solicitudservicio)
        {
            var solicitudservicioEncontrado = _appContext.SolicitudServicio.FirstOrDefault(m=>m.Id == solicitudservicio.Id);
            if (solicitudservicioEncontrado!=null)
            {
                solicitudservicioEncontrado.Servicio = solicitudservicio.Servicio;
                solicitudservicioEncontrado.Descripcion = solicitudservicio.Descripcion;
                solicitudservicioEncontrado.nivelPrioridad = solicitudservicio.nivelPrioridad;
                solicitudservicioEncontrado.FechaSolicitud = solicitudservicio.FechaSolicitud;
                solicitudservicioEncontrado.FechaAceptacionSolicitud = solicitudservicio.FechaAceptacionSolicitud;
                solicitudservicioEncontrado.estadoSolicitud = solicitudservicio.estadoSolicitud;
                solicitudservicioEncontrado.Entidad = solicitudservicio.Entidad;
                solicitudservicioEncontrado.migrante = solicitudservicio.migrante;
                solicitudservicioEncontrado.Evaluacion = solicitudservicio.Evaluacion;
                solicitudservicioEncontrado.ComportamientoMigrante = solicitudservicio.ComportamientoMigrante;
                
                _appContext.SaveChanges();
            }
            return solicitudservicioEncontrado;
        }
    }
}