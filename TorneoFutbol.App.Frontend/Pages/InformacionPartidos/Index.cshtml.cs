using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.InformacionPartidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioInformacionPartido _repoInformacionPartido;
        public IEnumerable <InformacionPartido> informacionpartido {get; set;}
        public IndexModel(IRepositorioInformacionPartido repoInformacionPartido)
        {
            _repoInformacionPartido = repoInformacionPartido;
        }
        public void OnGet()
        {
            informacionpartido = _repoInformacionPartido.GetAllInformacionPartido();
        }
    }
}
