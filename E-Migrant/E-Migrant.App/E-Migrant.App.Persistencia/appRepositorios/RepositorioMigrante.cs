using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class RepositorioMigrante : IRepositorioMigrante
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
        public RepositorioMigrante (appContext appContext)
        {
            _appContext=appContext;
        }

        Migrante IRepositorioMigrante.SearchFilter(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return _appContext.Migrante.FirstOrDefault(m => m.NumeroDocumento == searchString);
            }
            return null;
        }

        Migrante IRepositorioMigrante.AddMigrante(Migrante migrante)
        {
            var nitEncontrado = _appContext.Migrante.FirstOrDefault(m=>m.NumeroDocumento == migrante.NumeroDocumento);
            if (nitEncontrado == null)
            {
                var migranteAdicionado= _appContext.Migrante.Add(migrante);
                _appContext.SaveChanges();
                return migranteAdicionado.Entity;
            }
            return null;
        }

        bool IRepositorioMigrante.DeleteMigrante(int idMigrante)
        {
            var MigranteEncontrado= _appContext.Migrante.FirstOrDefault(m=>m.Id == idMigrante);
            if(MigranteEncontrado==null)
                return false;
            _appContext.Migrante.Remove(MigranteEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Migrante> IRepositorioMigrante.GetAllMigrante()
        {
            return _appContext.Migrante;
        }

        Migrante IRepositorioMigrante.GetMigrante(int idMigrante)
        {
            return _appContext.Migrante.FirstOrDefault(m=>m.Id == idMigrante);
        }

        Migrante IRepositorioMigrante.UpdateMigrante(Migrante migrante)
        {
            var migranteEncontrado = _appContext.Migrante.FirstOrDefault(m=>m.Id == migrante.Id);
            if (migranteEncontrado!=null)
            {
                migranteEncontrado.Nombre = migrante.Nombre;
                migranteEncontrado.Apellidos = migrante.Apellidos;
                migranteEncontrado.tipoDocumento = migrante.tipoDocumento;
                migranteEncontrado.NumeroDocumento = migrante.NumeroDocumento;
                migranteEncontrado.PaisOrigen = migrante.PaisOrigen;
                migranteEncontrado.FechaNacimiento = migrante.FechaNacimiento;
                migranteEncontrado.Email = migrante.Email;
                migranteEncontrado.Telefono = migrante.Telefono;
                migranteEncontrado.Direccion = migrante.Direccion;
                migranteEncontrado.Ciudad = migrante.Ciudad;
                migranteEncontrado.SituacionLaboral = migrante.SituacionLaboral;
                
                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }
    }
}