using System.Collections.Generic;
using AdeoseWeb.App.Dominio;


namespace AdeoseWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioServicioMemoria : IRepositorioServicio
    {
        
        List<Servicios> servicios;
        public RepositorioServicioMemoria()
        {
            servicios= new List<Servicios>()
            {
                new Servicios{Id=7, Nombre="Radicación Misiva", TipoServicio="Servicios Administrativos", Departamento="Recursos Administrativos"}
            };

        }
        public IEnumerable<Servicios> GetAll()
        {
            return servicios;
        }    
    }
}
    