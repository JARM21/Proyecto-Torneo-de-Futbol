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
    public class EditModel : PageModel
    {
        private readonly IRepositorioJugadores _repoJugador;
        public Jugador Jugador {get; set;}
        public EditModel(IRepositorioJugadores repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public IActionResult OnGet(int id)
        {
            Jugador = _repoJugador.GetJugador(id);
            if (Jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                _repoJugador.UpdateJugador(jugador);
                return RedirectToPage("Index");
            }

            else
            {
                return Page();
            }
            
        }
    }
}
