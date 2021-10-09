using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugadores _repoJugador;
        public IEnumerable <Jugador> jugadores {get; set;}

        public IndexModel(IRepositorioJugadores repojugador)
        {
            _repoJugador = repojugador;
        }
        public void OnGet()
        {
            jugadores = _repoJugador.GetAllJugador();
        }
    }
}
