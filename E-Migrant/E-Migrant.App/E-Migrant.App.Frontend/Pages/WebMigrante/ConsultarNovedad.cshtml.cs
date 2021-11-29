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
    public class ConsultarNovedadModel : PageModel
    {
        private readonly IRepositorioNovedad _repositorioNovedad = new RepositorioNovedad(new appContext());
        public string buscar { set; get; }
        public Novedad novedadEncontrada { set; get; }
        public IEnumerable<Novedad> Novedad { get; set; }

        public void OnGet()
        {
            Novedad = _repositorioNovedad.GetAllNovedad();
            
        }
    
    }
}
