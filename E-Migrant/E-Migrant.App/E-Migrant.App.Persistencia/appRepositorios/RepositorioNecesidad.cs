using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioNecesidad : IRepositorioNecesidad
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
        public RepositorioNecesidad (appContext appContext)
        {
            _appContext=appContext;
        }

        Necesidad IRepositorioNecesidad.SearchFilter(int searchString)
        {
            if (searchString>0)
            {
                return _appContext.Necesidad.FirstOrDefault(n => n.Id == searchString);
            }
            return null;
        }

        Necesidad IRepositorioNecesidad.AddNecesidad(Necesidad necesidad)
        {
            var necesidadEncontrada = _appContext.Necesidad.FirstOrDefault(n=> n.Id == necesidad.Id);
            if (necesidadEncontrada == null)
            {
                var necesidadAdicionada= _appContext.Necesidad.Add(necesidad);
                _appContext.SaveChanges();
                return necesidadAdicionada.Entity;
            }
            return null;
        }

        bool IRepositorioNecesidad.DeleteNecesidad(int idNecesidad)
        {
            var necesidadEncontrada= _appContext.Necesidad.FirstOrDefault(n=>n.Id == idNecesidad);
            if(necesidadEncontrada==null)
                return false;
            _appContext.Necesidad.Remove(necesidadEncontrada);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Necesidad> IRepositorioNecesidad.GetAllNecesidad()
        {
            return _appContext.Necesidad;
        }

        Necesidad IRepositorioNecesidad.GetNecesidad(int idNecesidad)
        {
            return _appContext.Necesidad.FirstOrDefault(n=>n.Id == idNecesidad);
        }

        Necesidad IRepositorioNecesidad.UpdateNecesidad(Necesidad necesidad)
        {
            var necesidadEncontrada = _appContext.Necesidad.FirstOrDefault(n=>n.Id == necesidad.Id);
            if (necesidadEncontrada!=null)
            {
                necesidadEncontrada.Categorias = necesidad.Categorias;
                necesidadEncontrada.Descripcion = necesidad.Descripcion;
                necesidadEncontrada.NivelPrioridad = necesidad.NivelPrioridad;
                necesidadEncontrada.EstadoNecesidad = necesidad.EstadoNecesidad;

                _appContext.SaveChanges();
            }
            return necesidadEncontrada;

         }   
        
    }
}