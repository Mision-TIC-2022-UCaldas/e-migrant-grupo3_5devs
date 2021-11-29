using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioEmergencia : IRepositorioEmergencia
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
        public RepositorioEmergencia (appContext appContext)
        {
            _appContext=appContext;
        }

        Emergencia IRepositorioEmergencia.SearchFilter(int searchString)
        {
            if (searchString>0)
            {
                return _appContext.Emergencia.FirstOrDefault(n => n.Id == searchString);
            }
            return null;
        }

        Emergencia IRepositorioEmergencia.AddEmergencia(Emergencia emergencia)
        {
            var emergenciaEncontrada = _appContext.Emergencia.FirstOrDefault(n=> n.Id == emergencia.Id);
            if (emergenciaEncontrada == null)
            {
                var emergenciaAdicionada= _appContext.Emergencia.Add(emergencia);
                _appContext.SaveChanges();
                return emergenciaAdicionada.Entity;
            }
            return null;
        }

        bool IRepositorioEmergencia.DeleteEmergencia(int idEmergencia)
        {
            var emergenciaEncontrada= _appContext.Emergencia.FirstOrDefault(n=>n.Id == idEmergencia);
            if(emergenciaEncontrada==null)
                return false;
            _appContext.Emergencia.Remove(emergenciaEncontrada);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Emergencia> IRepositorioEmergencia.GetAllEmergencia()
        {
            return _appContext.Emergencia;
        }

        Emergencia IRepositorioEmergencia.GetEmergencia(int idEmergencia)
        {
            return _appContext.Emergencia.FirstOrDefault(n=>n.Id == idEmergencia);
        }

        Emergencia IRepositorioEmergencia.UpdateEmergencia(Emergencia emergencia)
        {
            var emergenciaEncontrada = _appContext.Emergencia.FirstOrDefault(n=>n.Id == emergencia.Id);
            if (emergenciaEncontrada!=null)
            {
                emergenciaEncontrada.TipoEmergencia = emergenciaEncontrada.TipoEmergencia;
                emergenciaEncontrada.Descripcion = emergenciaEncontrada.Descripcion;
                emergenciaEncontrada.EstadoEmergencia = emergenciaEncontrada.EstadoEmergencia;

                _appContext.SaveChanges();
            }
            return emergenciaEncontrada;

         }

    }
}
