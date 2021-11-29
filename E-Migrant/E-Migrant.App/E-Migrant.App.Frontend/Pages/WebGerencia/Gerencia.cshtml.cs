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
    public class GerenciaModel : PageModel
    {
        private readonly IRepositorioNovedad _repositorioNovedad = new RepositorioNovedad(new appContext());
        public IEnumerable<Novedad> Novedads { get; set; }
        public void OnGet()
        {
            Novedads = _repositorioNovedad.GetAllNovedad();
        }
    }
}
