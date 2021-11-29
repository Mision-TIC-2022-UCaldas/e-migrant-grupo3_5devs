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
    public class ConsultarEmergenciaModel : PageModel
    {
        private readonly IRepositorioEmergencia _repositorioEmergencia = new RepositorioEmergencia(new appContext());
        public string buscar { set; get; }
        public Emergencia emergenciaEncontrada { set; get; }
        public IEnumerable<Emergencia> Emergencia { get; set; }

        public void OnGet()
        {
            Emergencia = _repositorioEmergencia.GetAllEmergencia();
            
        }
    
    }
}
