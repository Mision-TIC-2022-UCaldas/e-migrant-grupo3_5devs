namespace E_Migrant.App.Dominio.Entidades
{
    public class Mensaje
    {
        public int Id {get;set;}
        public EstadoMensaje EstadoMensaje {get;set;}
        public string Contenido {get;set;}
        public Usuario Emisor {get;set;}
        public Usuario Receptor {get;set;}
    }
}