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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioInformacionPartido _repoInformacionPartido;
        public InformacionPartido informacionpartido {get; set;}
        public DetailsModel(IRepositorioInformacionPartido repoInformacionPartido)
        {
            _repoInformacionPartido = repoInformacionPartido;
        }
        public IActionResult OnGet(int id)
        {
            informacionpartido = _repoInformacionPartido.GetInformacionPartido(id);
            if (informacionpartido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
