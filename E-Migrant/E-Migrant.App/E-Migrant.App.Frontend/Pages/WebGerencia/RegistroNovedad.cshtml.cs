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
    public class RegistroNovedadModel : PageModel
    {
        private static IRepositorioNovedad _repositorioNovedad = new RepositorioNovedad(new appContext());
        [BindProperty]
        public Novedad novedad { get; set; }
        public IActionResult OnGet(int? idNovedad)
        {
            if (idNovedad.HasValue)
            {
                novedad = _repositorioNovedad.GetNovedad(idNovedad.Value);
            }
            else
            {
                novedad = new Novedad();
            }
 
            if (novedad == null)
            {
                return RedirectToPage("./Gerencia");
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
                if (novedad.Id > 0)
                {
                    _repositorioNovedad.UpdateNovedad(novedad);
                }
                else
                {
                    _repositorioNovedad.AddNovedad(novedad);
                }
            }
            return RedirectToPage("./Gerencia");
        }
    }
}
