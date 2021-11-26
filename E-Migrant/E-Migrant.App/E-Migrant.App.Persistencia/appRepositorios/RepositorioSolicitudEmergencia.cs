using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.SolicitudEmergenciaes;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioSolicitudEmergencia : IRepositorioSolicitudEmergencia
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
        public RepositorioSolicitudEmergencia (appContext appContext)
        {
            _appContext=appContext;
        }
        SolicitudEmergencia IRepositorioSolicitudEmergencia.AddSolicitudEmergencia(SolicitudEmergencia solicitudemergencia)
        {
            var solicitudemergenciaAdicionada= _appContext.SolicitudEmergencia.Add(solicitudemergencia);
            _appContext.SaveChanges();
            return solicitudemergenciaAdicionada.Entity;
        }

        bool IRepositorioSolicitudEmergencia.DeleteSolicitudEmergencia(int idSolicitudEmergencia)
        {
            var SolicitudEmergenciaEncontrada= _appContext.SolicitudEmergencia.FirstOrDefault(m=>m.Id == idSolicitudEmergencia);
            if(SolicitudEmergenciaEncontrada==null)
                return false;
            _appContext.SolicitudEmergencia.Remove(SolicitudEmergenciaEncontrada);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<SolicitudEmergencia> IRepositorioSolicitudEmergencia.GetAllSolicitudEmergencia()
        {
            return _appContext.SolicitudEmergencia;
        }

        SolicitudEmergencia IRepositorioSolicitudEmergencia.GetSolicitudEmergencia(int idSolicitudEmergencia)
        {
            return _appContext.SolicitudEmergencia.FirstOrDefault(m=>m.Id == idSolicitudEmergencia);
        }

        SolicitudEmergencia IRepositorioSolicitudEmergencia.UpdateSolicitudEmergencia(SolicitudEmergencia solicitudemergencia)
        {
            var solicitudemergenciaEncontrada = _appContext.SolicitudEmergencia.FirstOrDefault(m=>m.Id == solicitudemergencia.Id);
            if (solicitudemergenciaEncontrada!=null)
            {
                solicitudemergenciaEncontrada.Descripcion = solicitudemergencia.Descripcion;
                solicitudemergenciaEncontrada.Direccion = solicitudemergencia.Direccion;
                solicitudemergenciaEncontrada.FechaSolicitud = solicitudemergencia.FechaSolicitud;
                solicitudemergenciaEncontrada.tipoEmergencia = solicitudemergencia.tipoEmergencia;
                solicitudemergenciaEncontrada.estadoEmergencia = solicitudemergencia.estadoEmergencia;
                
                _appContext.SaveChanges();
            }
            return solicitudemergenciaEncontrado;
        }
    }
}