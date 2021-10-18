using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.DirectoresTecnicos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directorTecnico { get; set; }
        public EditModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public IActionResult OnGet(int id)
        {
            directorTecnico = _repoDirectorTecnico.GetDirectoresTecnicos(id);
            if (directorTecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            if (ModelState.IsValid)
            {
                _repoDirectorTecnico.UpdateDirectoresTecnicos(directorTecnico);
                return RedirectToPage("Index");
            }

            else
            {
                return Page();
            }
            
        }
    }
}
