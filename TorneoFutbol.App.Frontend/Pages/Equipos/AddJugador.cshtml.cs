using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Equipos
{
    public class AddJugadorModel : PageModel
    {
        private readonly IRepositorioEquipos _repoEquipo;
         private readonly IRepositorioJugadores _repoJugador;
        public Equipo equipo {get; set;}
        public IEnumerable<Jugador> jugadores {get; set;}
  
        public AddJugadorModel(IRepositorioEquipos repoEquipo, IRepositorioJugadores repoJugador)
        {
            _repoEquipo = repoEquipo;
            _repoJugador = repoJugador;
        }
        public void OnGet(int Id)
        {
            equipo =_repoEquipo.GetEquipos(Id);
            jugadores = _repoJugador.GetAllJugador();
        }

        public IActionResult OnPost(int IdEquipo, int IdJugador)
        {
            _repoEquipo.AsignarJugador(IdEquipo, IdJugador);
            return RedirectToPage("Details", new{Id = IdEquipo});
        }
    }
}
