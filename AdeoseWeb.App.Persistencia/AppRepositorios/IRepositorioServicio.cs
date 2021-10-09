using System.Collections.Generic;
using AdeoseWeb.App.Dominio;

namespace AdeoseWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioServicio
    {
         IEnumerable<Servicios> GetAll();
         //AddServicio(Servicio servicios);

    }
}
