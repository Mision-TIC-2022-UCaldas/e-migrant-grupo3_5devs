using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;

namespace E_Migrant.App.Frontend.Pages
{
    public class ServiciosMigranteModel : PageModel
    {
        private static IRepositorioMigrante _repositorioMigrante = new RepositorioMigrante(new appContext());
        public IEnumerable<Migrante> Migrantes { get; set; }
        public void OnGet()
        {
            Migrantes = _repositorioMigrante.GetAllMigrante();
        }
    }
}
