using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace E_Migrant.App.Frontend.Pages
{
    //[Authorize]
    public class EntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repositorioEntidad = new RepositorioEntidad(new appContext());
        public IEnumerable<Entidad> Entidads { get; set; }
        public string usuario;
        public void OnGet()
        {
            Entidads = _repositorioEntidad.GetAllEntidad();
            usuario = User.Identity.Name;
        }
    }
}
