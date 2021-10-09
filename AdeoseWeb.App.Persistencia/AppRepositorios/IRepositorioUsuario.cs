using System.Collections.Generic;
using AdeoseWeb.App.Dominio;
namespace AdeoseWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAll();

    }
}