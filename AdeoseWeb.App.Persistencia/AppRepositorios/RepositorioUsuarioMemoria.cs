using System.Collections.Generic;
using AdeoseWeb.App.Dominio;
namespace AdeoseWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarioMemoria: IRepositorioUsuario
    {
        List<Usuario> usuarios;
        public RepositorioUsuarioMemoria()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{Id=7, Ciudad="Medellin", Telefono= 5544455, Diligencia="Asesorias", CorreoElectrónico="revision@gmail.com", TipoUsuario="Persona Natural", Direccion="Getsemani calle del pozo"}
            };

        }
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }    
    }
}