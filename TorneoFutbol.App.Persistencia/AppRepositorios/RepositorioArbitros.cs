using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioArbitros : IRepositorioArbitros
    {
        private readonly AppContext _appContext;
        public RepositorioArbitros(AppContext appContext)
        {
            _appContext=appContext;
        }

        Arbitros IRepositorioArbitros.AddArbitro(Arbitros arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }

        void IRepositorioArbitros.DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado=_appContext.Arbitros.FirstOrDefault(m=>m.Id==idArbitro);
            if(arbitroEncontrado==null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Arbitros> IRepositorioArbitros.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        Arbitros IRepositorioArbitros.GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.FirstOrDefault(m=>m.Id==idArbitro);
            
        }

        Arbitros IRepositorioArbitros.UpdateArbitro(Arbitros arbitro)
        {
            var arbitroEncontrado=_appContext.Arbitros.FirstOrDefault(m=>m.Id==arbitro.Id);
            if(arbitroEncontrado!=null)
            {
                arbitroEncontrado.Nombre = arbitro.Nombre;
                arbitroEncontrado.Documento = arbitro.Documento;
                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }
    }
}