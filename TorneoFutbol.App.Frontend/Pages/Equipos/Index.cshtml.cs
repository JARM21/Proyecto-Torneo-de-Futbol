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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipos _repoEquipo;
        public IEnumerable <Equipo> equipo {get; set;}
        public IndexModel(IRepositorioEquipos repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }
        public void OnGet()
        {
            equipo = _repoEquipo.GetAllEquipos();
        }
    }
}
