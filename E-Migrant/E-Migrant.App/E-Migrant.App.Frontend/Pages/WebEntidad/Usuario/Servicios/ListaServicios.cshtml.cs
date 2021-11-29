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
    public class ListaServiciosModel : PageModel
    {
        private readonly IRepositorioEntidad _repositorioEntidad = new RepositorioEntidad(new appContext());
        private readonly IRepositorioServicio _repositorioServicio = new RepositorioServicio(new appContext());
        public List<Entidad> entidades { get; set; }
        public IEnumerable<Servicio> servicios1 { get; set; }
        public Servicio servicio { get; set; }
        public Entidad entidad {get;set;}
        public string usuario;
        public void OnGet()
        {
            usuario = User.Identity.Name;
            entidad = _repositorioEntidad.SearchEmail(usuario);
            entidades = _repositorioEntidad.GetServicios(entidad.Id);
        }
    }
}
