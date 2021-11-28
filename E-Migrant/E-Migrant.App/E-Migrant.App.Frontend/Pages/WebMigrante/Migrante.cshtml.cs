using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace E_Migrant.App.Frontend.Pages
{
    //[Authorize]
    public class MigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repositorioMigrante = new RepositorioMigrante(new appContext());
        public IEnumerable<Migrante> Migrantes { get; set; }
        public void OnGet()
        {
            Migrantes = _repositorioMigrante.GetAllMigrante();
        }
    }
}
