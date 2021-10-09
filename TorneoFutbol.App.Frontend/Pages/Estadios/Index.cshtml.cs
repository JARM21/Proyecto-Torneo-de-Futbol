using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;
=======
>>>>>>> 14f503baa826c5b36d55961af0553170b41d8714

namespace TorneoFutbol.App.Frontend.Pages.Estadios
{
    public class IndexModel : PageModel
    {
<<<<<<< HEAD
        private readonly IRepositorioEstadios _repoEstadio;
        public IEnumerable <Estadio> estadio {get; set;}
        public IndexModel(IRepositorioEstadios repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }
        public void OnGet()
        {
            estadio = _repoEstadio.GetAllEstadios();
=======
        public void OnGet()
        {
>>>>>>> 14f503baa826c5b36d55961af0553170b41d8714
        }
    }
}
