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
    public class EntidadModel : PageModel
    {
        private static IRepositorioEntidad _repositorioEntidad = new RepositorioEntidad(new appContext());
        public IEnumerable<Entidad> Entidads { get; set; }
        public void OnGet()
        {
            Entidads = _repositorioEntidad.GetAllEntidad();
        }
    }
}
