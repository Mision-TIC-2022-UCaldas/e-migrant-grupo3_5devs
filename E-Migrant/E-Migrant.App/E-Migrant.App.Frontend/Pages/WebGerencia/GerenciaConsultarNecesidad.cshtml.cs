using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace E_Migrant.App.Frontend.Pages
{
    public class GerenciaConsultarNecesidadModel : PageModel
    {
        private readonly IRepositorioNecesidad _repositorioNecesidad = new RepositorioNecesidad(new appContext());
        public string buscar { set; get; }
        public Necesidad necesidadEncontrada { set; get; }
        public IEnumerable<Necesidad> Necesidades { get; set; }
        [BindProperty(SupportsGet = true)]
        public string filtroNecesidad {get;set;}
        private readonly ILogger<GerenciaConsultarNecesidadModel> _logger;

        public GerenciaConsultarNecesidadModel (ILogger<GerenciaConsultarNecesidadModel> logger)
    {
        _logger = logger;
    }

        public void OnGet()
        {
            Necesidades = _repositorioNecesidad.GetAllNecesidad();
            _logger.LogInformation($"OnGet {filtroNecesidad}");
        }

        public void OnPostFiltrar(string name)
        {
            _logger.LogInformation($"OnGetDownload {name}");
        }

        
    
    }
}
