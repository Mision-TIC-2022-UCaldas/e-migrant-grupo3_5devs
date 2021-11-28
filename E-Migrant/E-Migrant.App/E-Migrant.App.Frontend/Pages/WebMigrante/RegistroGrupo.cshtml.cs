using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Migrant.App.Frontend.Pages
{
    public class RegistroGrupoModel : PageModel
    {
        private static IRepositorioMigrante _repositorioMigrante = new RepositorioMigrante(new appContext());
        [BindProperty]
        public Migrante migrante { get; set; }
        public IActionResult OnGet(int idMigrante)
        {
            migrante = _repositorioMigrante.GetMigrante(idMigrante);
            if (migrante == null)
            {
                return RedirectToPage("./Migrante");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                    _repositorioMigrante.UpdateMigrante(migrante);
            }
            return RedirectToPage("./Migrante");
        }
    }
}
