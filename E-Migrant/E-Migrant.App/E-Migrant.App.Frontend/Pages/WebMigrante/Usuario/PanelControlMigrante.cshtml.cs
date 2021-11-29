using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace E_Migrant.App.Frontend.Pages
{
    public class PanelControlMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repositorioMigrante = new RepositorioMigrante(new appContext());
        public Migrante migrante { get; set; }
        public string usuario;
        public void OnGet()
        {
            usuario = User.Identity.Name;
            migrante = _repositorioMigrante.SearchEmail(usuario);
        }
    }
}
