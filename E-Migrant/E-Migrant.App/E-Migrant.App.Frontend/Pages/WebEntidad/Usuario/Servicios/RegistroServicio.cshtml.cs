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
    public class RegistroServicioModel : PageModel
    {
        private readonly IRepositorioEntidad _repositorioEntidad = new RepositorioEntidad(new appContext());
        private static IRepositorioServicio _repositorioServicio = new RepositorioServicio(new appContext());
        [BindProperty]
        public Servicio servicio { get; set; }
        public Entidad entidad {get;set;}
        public string usuario;
        public IActionResult OnGet(int? idServicio)
        {
            usuario = User.Identity.Name;
            entidad = _repositorioEntidad.SearchEmail(usuario);
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
                return RedirectToPage("../PanelControlEntidad");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            usuario = User.Identity.Name;
            entidad = _repositorioEntidad.SearchEmail(usuario);
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
                    //_repositorioServicio.AddServicio(servicio);
                    _repositorioEntidad.AddServicio(entidad.Id, servicio);
                }
            }
            return RedirectToPage("../PanelControlEntidad");
        }
    }
}
