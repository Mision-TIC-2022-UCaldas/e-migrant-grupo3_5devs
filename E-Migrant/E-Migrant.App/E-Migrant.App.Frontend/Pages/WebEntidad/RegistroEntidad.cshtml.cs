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
    public class RegistroEntidadModel : PageModel
    {
        private static IRepositorioEntidad _repositorioEntidad = new RepositorioEntidad(new appContext());
        [BindProperty]
        public Entidad entidad { get; set; }
        public IActionResult OnGet(int? idEntidad)
        {
            if (idEntidad.HasValue)
            {
                entidad = _repositorioEntidad.GetEntidad(idEntidad.Value);
            }
            else
            {
                entidad = new Entidad();
            }

            if (entidad == null)
            {
                return RedirectToPage("./Entidad");
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
                if (entidad.Id > 0)
                {
                    _repositorioEntidad.UpdateEntidad(entidad);
                }
                else
                {
                    _repositorioEntidad.AddEntidad(entidad);
                }
            }
            return RedirectToPage("./Entidad");
        }
    }
}
