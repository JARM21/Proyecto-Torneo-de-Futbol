using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEstadios : IRepositorioEstadios
    {
        private readonly AppContext _appContext;
        public RepositorioEstadios(AppContext appContext)
        {
            _appContext=appContext;
        }

        Estadios IRepositorioEstadios.AddEstadio(Estadios estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }

        void IRepositorioEstadios.DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado=_appContext.Estadios.FirstOrDefault(e=>e.Id==idEstadio);
            if(estadioEncontrado==null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estadios> IRepositorioEstadios.GetAllEstadios()
        {
            return _appContext.Estadios;
        }

        Estadios IRepositorioEstadios.GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.FirstOrDefault(e=>e.Id==idEstadio);
            
        }

        Estadios IRepositorioEstadios.UpdateEstadio(Estadios estadio)
        {
            var estadioEncontrado=_appContext.Estadios.FirstOrDefault(e=>e.Id==estadio.Id);
            if(estadioEncontrado!=null)
            {
                estadioEncontrado.Nombre = estadio.Nombre;
                estadioEncontrado.Direccion = estadio.Direccion;
                estadioEncontrado.Municipio = estadio.Municipio;
                
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
    }
}