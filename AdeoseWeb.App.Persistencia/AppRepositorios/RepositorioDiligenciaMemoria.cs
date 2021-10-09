using System.Collections.Generic;
using AdeoseWeb.App.Dominio;

namespace AdeoseWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioDiligenciaMemoria : IRepositorioDiligencia
    {
        
        List<Diligencia> diligencias;
        public RepositorioDiligenciaMemoria()
        {
            diligencias= new List<Diligencia>()
            {
                new Diligencia{Id=7, Fecha="23/10/2021", Hora="8:00", Departamento="Investigaciones", TipoDiligencia="Asesoría", Usuario="Daniela Olascoaga", Descripcion="Ayuda con proyecto de investigacion"}
            };

        }
        public IEnumerable<Diligencia> GetAll()
        {
            return diligencias;
        }    
    }
}
    
