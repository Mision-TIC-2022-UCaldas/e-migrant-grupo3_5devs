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
    public class ListaMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repositorioMigrante = new RepositorioMigrante(new appContext());
        public string buscar { set; get; }
        public Migrante encontradoMigrante { set; get; }
        public IEnumerable<Migrante> Migrantes { get; set; }
        public IActionResult OnGet(string? buscar)
        {
            Migrantes = _repositorioMigrante.GetAllMigrante();
            encontradoMigrante = _repositorioMigrante.SearchFilter(buscar);
            return Page();
        }
    }
}
