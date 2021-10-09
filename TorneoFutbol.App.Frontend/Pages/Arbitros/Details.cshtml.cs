using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Arbitros
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioArbitros _repoArbitro;
        public Arbitro arbitros {get; set;}
        public DetailsModel(IRepositorioArbitros repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public IActionResult OnGet(int id)
        {
            arbitros = _repoArbitro.GetArbitro(id);
            if (arbitros == null)
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