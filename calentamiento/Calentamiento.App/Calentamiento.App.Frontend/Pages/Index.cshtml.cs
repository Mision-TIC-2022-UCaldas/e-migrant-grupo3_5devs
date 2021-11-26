using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Calentamiento.App.Dominio;

namespace Calentamiento.App.Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        public void OnGet()
        {
            //IMC = new IMC;
        }

        
        /*public double CalcularIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            return imc;
        }

        public void IMCMesagge(double imc)
        {
            switch (imc)
            {
                case < 16.0:
                    String message = "Delgadez severa";
                    break;

                case < 16.99:
                    String message = "Delgadez moderada";
                    break;

                case < 18.49:
                    String message = "Delgadez aceptable";
                    break;

                case < 24.99:
                    String message = "Peso normal";
                    break;

                case < 29.99:
                    String message = "Sobrepeso";
                    break;

                case < 34.99:
                    String message = "Obesidad tipo I";
                    break;

                case < 39.99:
                    String message = "Obesidad tipo II";
                    break;

                case < 49.99:
                    String message = "Obesidad tipo III o mórbida";
                    break;

                case > 50:
                    String message = "Obesidad tipo IV o extrema";
                    break;

                default:
                    String message = "Ingrese correctamente su peso y altura";
                    break;
            }
        }*/
    }
}
