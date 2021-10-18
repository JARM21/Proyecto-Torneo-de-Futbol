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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartidos _repoPartido;
        public Partido partido {get; set;}
        private readonly IRepositorioEquipos _repoEquipo;
        public IEnumerable <Equipo> equipos {get; set;}

        public CreateModel(IRepositorioPartidos repoPartido, IRepositorioEquipos repoEquipo)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
        }
        public void OnGet()
        {
            partido = new Partido();
            equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(Partido partido, int idEquipoLocal, int idEquipoVisitante)
        {
            if (ModelState.IsValid)
            {
                _repoPartido.AddPartidos(partido);
                _repoPartido.AsignarEquipoLocal(partido.Id, idEquipoLocal);
                _repoPartido.AsignarEquipoVisitante(partido.Id, idEquipoVisitante);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
