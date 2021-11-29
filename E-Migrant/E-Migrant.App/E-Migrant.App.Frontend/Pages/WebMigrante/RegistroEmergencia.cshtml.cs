using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;

namespace E_Migrant.App.Frontend.Pages
{
    public class RegistroEmergenciaModel : PageModel
    {
        private static IRepositorioEmergencia _repositorioEmergencia = new RepositorioEmergencia(new appContext());
        [BindProperty]
        public Emergencia emergencia { get; set; }

        public IActionResult OnGet(int? idEmergencia)
        {
            if (idEmergencia.HasValue)
            {
                emergencia = _repositorioEmergencia.GetEmergencia(idEmergencia.Value);
            }
            else
            {
                emergencia = new Emergencia();
            }

            if (emergencia == null)
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
                if (emergencia.Id > 0)
                {
                    _repositorioEmergencia.UpdateEmergencia(emergencia);
                }
                else
                {
                    _repositorioEmergencia.AddEmergencia(emergencia);
                }
            }
            return RedirectToPage("./Migrante");
        }
    }
}
