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
    public class ServicioModel : PageModel
    {
        private readonly IRepositorioServicio _repositorioServicio = new RepositorioServicio(new appContext());
        public IEnumerable<Servicio> servicios { get; set; }
        public void OnGet()
        {
            servicios = _repositorioServicio.GetAllServicio();

        }
    }
}
