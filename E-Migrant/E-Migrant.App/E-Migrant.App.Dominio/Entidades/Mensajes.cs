namespace E_Migrant.App.Dominio.Entidades
{
    public class Mensajes
    {
        public int Id {get;set;}
        public string EstadoMensaje {get;set;}
        public string Contenido {get;set;}
        public Usuario Emisor {get;set;}
        public Usuario Receptor {get;set;}
    }
}