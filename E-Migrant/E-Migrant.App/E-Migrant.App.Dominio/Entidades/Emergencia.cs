namespace E_Migrant.App.Dominio.Entidades
{
    public class Emergencia
    {
        public int Id {get;set;}
        public TipoEmergencia TipoEmergencia {get;set;}
        public string Descripcion {get;set;}
        public EstadoEmergencia EstadoEmergencia {get;set;}
    }
}