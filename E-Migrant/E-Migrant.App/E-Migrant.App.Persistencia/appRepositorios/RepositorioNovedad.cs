using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioNovedad : IRepositorioNovedad
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
        public RepositorioNovedad (appContext appContext)
        {
            _appContext=appContext;
        }
        Novedad IRepositorioNovedad.AddNovedad(Novedad novedad)
        {
            var novedadAdicionado= _appContext.Novedad.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }

        bool IRepositorioNovedad.DeleteNovedad(int idNovedad)
        {
            var NovedadEncontrado= _appContext.Novedad.FirstOrDefault(m=>m.Id == idNovedad);
            if(NovedadEncontrado==null)
                return false;
            _appContext.Novedad.Remove(NovedadEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Novedad> IRepositorioNovedad.GetAllNovedad()
        {
            return _appContext.Novedad;
        }

        Novedad IRepositorioNovedad.GetNovedad(int idNovedad)
        {
            return _appContext.Novedad.FirstOrDefault(m=>m.Id == idNovedad);
        }

        Novedad IRepositorioNovedad.UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrada = _appContext.Novedad.FirstOrDefault(m=>m.Id == novedad.Id);
            if (novedadEncontrada!=null)
            {
                novedadEncontrada.FechaInicio = novedad.FechaInicio;
                novedadEncontrada.DiasNovedad = novedad.DiasNovedad;
                novedadEncontrada.Descripcion = novedad.Descripcion;
                
                _appContext.SaveChanges();
            }
            return novedadEncontrada;
        }
    }
}