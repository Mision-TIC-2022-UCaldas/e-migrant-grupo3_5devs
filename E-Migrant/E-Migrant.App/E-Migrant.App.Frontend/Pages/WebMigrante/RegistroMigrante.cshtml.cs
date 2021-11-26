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
    public class RegistroMigranteModel : PageModel
    {
        private static IRepositorioMigrante _repositorioMigrante = new RepositorioMigrante(new appContext());
        [BindProperty]
        public Migrante migrante { get; set; }
        public IActionResult OnGet(int? idMigrante)
        {
            if (idMigrante.HasValue)
            {
                migrante = _repositorioMigrante.GetMigrante(idMigrante.Value);
            }
            else
            {
                migrante = new Migrante();
            }

            if (migrante == null)
            {
                return RedirectToPage("./ServiciosMigrante");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (migrante.Id > 0)
                {
                    _repositorioMigrante.UpdateMigrante(migrante);
                }
                else
                {
                    _repositorioMigrante.AddMigrante(migrante);
                }
            }
            return RedirectToPage("./ServiciosMigrante");
        }
    }
}
