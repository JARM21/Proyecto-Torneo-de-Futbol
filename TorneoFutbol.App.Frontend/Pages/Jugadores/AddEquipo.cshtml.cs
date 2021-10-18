using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages
{
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioEquipos _repoEquipo;
        private readonly IRepositorioJugadores _repoJugador;
        public Jugador Jugador {get; set;}
        public IEnumerable<Equipo> Equipos {get; set;}

        public AddEquipoModel(IRepositorioEquipos repoEquipo, IRepositorioJugadores repoJugador)
        {
            _repoEquipo = repoEquipo;
            _repoJugador = repoJugador;
        }
        public void OnGet(int id)
        {
            Jugador = _repoJugador.GetJugador(id);
            Equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(int idJugador, int idEquipo)
        {
            _repoJugador.AsignarEquipo(idJugador, idEquipo);
            return RedirectToPage("Details", new{Id = idJugador});
        }
    }
}
