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
    public class RegistrarServicioModel : PageModel
    {
        private static IRepositorioServicio _repositorioServicio = new RepositorioServicio(new appContext());
        [BindProperty]
        public Servicio servicio { get; set; }
        public IActionResult OnGet(int? idServicio)
        {
            if (idServicio.HasValue)
            {
                servicio = _repositorioServicio.GetServicio(idServicio.Value);
            }
            else
            {
                servicio = new Servicio();
            }

            if (servicio == null)
            {
                return RedirectToPage("./Servicio");
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
                if (servicio.Id > 0)
                {
                    _repositorioServicio.UpdateServicio(servicio);
                }
                else
                {
                    _repositorioServicio.AddServicio(servicio);
                }
            }
            return RedirectToPage("./Servicio");
        }
    }
}
