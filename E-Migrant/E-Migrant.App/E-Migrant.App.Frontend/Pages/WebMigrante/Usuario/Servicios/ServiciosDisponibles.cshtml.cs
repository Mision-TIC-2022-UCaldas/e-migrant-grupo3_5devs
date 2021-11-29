using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.appRepositorios;
using Microsoft.Extensions.Logging;

namespace E_Migrant.App.Frontend.Pages
{
    public class ServiciosDisponiblesModel : PageModel
    {
        private readonly IRepositorioServicio _repositorioServicio = new RepositorioServicio(new appContext());
        public IEnumerable<Servicio> servicios { get; set; }
        [BindProperty(SupportsGet = true)]
        public string filtroTipoServicio {get;set;}
        private readonly ILogger<ServiciosDisponiblesModel> _logger;
        public ServiciosDisponiblesModel(ILogger<ServiciosDisponiblesModel> logger)
        {
        _logger = logger;
        }

        public void OnGet()
        {
            servicios = _repositorioServicio.GetAllServicio();
            _logger.LogInformation($"OnGet {filtroTipoServicio}");
            //string entidadId = servicios.TipoServicio.ToString();

        }
        public void OnPostFiltrar(string name)
        {
            _logger.LogInformation($"OnGetDownload {name}");
        }
    }
}
