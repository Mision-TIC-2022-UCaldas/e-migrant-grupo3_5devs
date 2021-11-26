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
    public class ListadoUsuariosModel : PageModel
    {
        private static IRepositorioUsuario _repositorioUsuario = new RepositorioUsuario(new appContext());
        [BindProperty]
        public Usuario usuario { get; set; }
        public IEnumerable<Usuario> Usuarios {get;set;}
        public UsuariosModel (IRepositorioUsuario _repoUsuario)
            {
                this._repoUsuario=_repoUsuario;
                
            }
        public void OnGet()
        {
            Usuarios = _repoUsuarios.GetAllUsuario();
        }
    }
}
