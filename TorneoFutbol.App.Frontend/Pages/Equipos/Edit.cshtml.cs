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
    public class EditModel : PageModel
    {
        private readonly IRepositorioEquipos _repoEquipos;
        public Equipo Equipo { get; set; }
        public EditModel(IRepositorioEquipos repoEquipos)
        {
            _repoEquipos = repoEquipos;
        }
        public IActionResult OnGet(int id)
        {
            Equipo = _repoEquipos.GetEquipos(id);
            if (Equipo == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Equipo Equipo)
        {
            if (ModelState.IsValid)
            {
                _repoEquipos.UpdateEquipos(Equipo);
                return RedirectToPage("Index");
            }

            else
            {
                return Page();
            }
            
        }
    }
}
