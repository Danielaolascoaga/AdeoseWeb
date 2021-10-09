using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdeoseWeb.App.Persistencia.AppRepositorios;
using AdeoseWeb.App.Dominio;

namespace AdeoseWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //private string[] servicios = {"Asesorias", "Reparación y Mantenimiento", "Diseño y Creación de productos y/o servicios personalizados", "Cotizaciones"};
        //public List<string> ListaServicios {get; set;}       
       private readonly IRepositorioServicio repositorioServicio;

        public IEnumerable<Servicios> ListServicios{get;set;}
        
        public  ListModel(IRepositorioServicio repositorioServicio)
        {
            this.repositorioServicio=repositorioServicio;
        }
        public void OnGet()
        {
            //Servicios service= new Servicios();
            ListServicios = repositorioServicio.GetAll();
            //ListaServicios.AddRange(servicios);
            //service = repositorioServicio.GetAll();
        }

      
    }
}
