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
    public class ListaEntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repositorioEntidad = new RepositorioEntidad(new appContext());
        public string buscar { set; get; }
        public Entidad encontradoEntidad { set; get; }
        public IEnumerable<Entidad> Entidads { get; set; }
        public IActionResult OnGet(string? buscar)
        {
            Entidads = _repositorioEntidad.GetAllEntidad();
            encontradoEntidad = _repositorioEntidad.SearchFilter(buscar);
            return Page();
        }
    }
}
