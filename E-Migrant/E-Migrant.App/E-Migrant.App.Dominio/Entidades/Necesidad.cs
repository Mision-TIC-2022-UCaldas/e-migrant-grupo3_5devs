using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Necesidad
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "La Categoria es obligatoria.")]
        public Categorias Categorias {get;set;}
        [Required (ErrorMessage = "La descripcion es obligatoria.")]
        public string Descripcion {get;set;} 
        [Required (ErrorMessage = "El Nivel de prioridad es obligatorio.")]
        public NivelPrioridad NivelPrioridad {get;set;} 


    }
}