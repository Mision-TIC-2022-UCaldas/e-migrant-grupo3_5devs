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
    public class GerenciaConsultarNecesidadModel : PageModel
    {
        private readonly IRepositorioNecesidad _repositorioNecesidad = new RepositorioNecesidad(new appContext());
        public string buscar { set; get; }
        public Necesidad necesidadEncontrada { set; get; }
        public IEnumerable<Necesidad> Necesidades { get; set; }

        public void OnGet()
        {
            Necesidades = _repositorioNecesidad.GetAllNecesidad();
            
        }

        
    
    }
}
