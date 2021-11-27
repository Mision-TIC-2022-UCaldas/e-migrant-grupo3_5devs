using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Usuario
    {
        public int Id {get;set;}
        public string Username {get;set;}
        public string Password {get;set;}
        public Rol rol {get;set;}
    }
}