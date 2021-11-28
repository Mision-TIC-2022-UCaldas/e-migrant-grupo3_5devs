using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;

namespace E_Migrant.App.Frontend.Pages
{
    public class RegistroNecesidadModel : PageModel
    {
        private static IRepositorioNecesidad _repositorioNecesidad = new RepositorioNecesidad(new appContext());
        [BindProperty]
        public Necesidad necesidad { get; set; }

        public IActionResult OnGet(int? idNecesidad)
        {
            if (idNecesidad.HasValue)
            {
                necesidad = _repositorioNecesidad.GetNecesidad(idNecesidad.Value);
            }
            else
            {
                necesidad = new Necesidad();
            }

            if (necesidad == null)
            {
                return RedirectToPage("./Migrante");
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
                if (necesidad.Id > 0)
                {
                    _repositorioNecesidad.UpdateNecesidad(necesidad);
                }
                else
                {
                    _repositorioNecesidad.AddNecesidad(necesidad);
                }
            }
            return RedirectToPage("./Migrante");
        }
    }
}
