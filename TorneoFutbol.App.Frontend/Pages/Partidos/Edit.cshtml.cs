using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Partidos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPartidos _repoPartido;
        private readonly IRepositorioArbitros _repoArbitro;
        private readonly IRepositorioEstadios _repoEstadio;
        public Partido Partido {get; set;}
        public IEnumerable<Arbitro> arbitro {get; set;}
        public IEnumerable<Estadio> estadio {get; set;}
        public EditModel(IRepositorioPartidos repoPartido, 
        IRepositorioEstadios repoEstadio,IRepositorioArbitros repoArbitro)
        {
            _repoPartido = repoPartido;
            _repoArbitro = repoArbitro;
            _repoEstadio = repoEstadio;
        }
        public IActionResult OnGet(int id)
        {
            Partido = _repoPartido.GetPartido(id);
            estadio = _repoEstadio.GetAllEstadios();            
            arbitro = _repoArbitro.GetAllArbitros();
            if (Partido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Partido Partido,int IdPartido, int IdArbitro, int IdEstadio)
        {
            if (ModelState.IsValid)
            {
                _repoPartido.UpdatePartido(Partido);
                _repoPartido.AsignarArbitro(IdPartido, IdArbitro);
                _repoPartido.AsignarEstadio(IdPartido, IdEstadio);
                return RedirectToPage("Index");
            }

            else
            {
                return Page();
            }
            
        }
    }
}
