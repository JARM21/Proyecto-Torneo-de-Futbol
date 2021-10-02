using System;
using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioMunicipios : IRepositorioMunicipios
    {
        private readonly AppContext _appContext = new AppContext();
        
        Municipios IRepositorioMunicipios.AddMunicipio(Municipios municipio)
        {
            var MunicipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return MunicipioAdicionado.Entity;
        }

        void IRepositorioMunicipios.DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado=_appContext.Municipios.FirstOrDefault(m=>m.Id==idMunicipio);
            if(municipioEncontrado==null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Municipios> IRepositorioMunicipios.GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

        Municipios IRepositorioMunicipios.GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.FirstOrDefault(m=>m.Id==idMunicipio);
            
        }

        Municipios IRepositorioMunicipios.UpdateMunicipio(Municipios municipio)
        {
            var municipioEncontrado=_appContext.Municipios.FirstOrDefault(m=>m.Id==municipio.Id);
            if(municipioEncontrado!=null)
            {
                municipioEncontrado.Nombre = municipio.Nombre;
                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }
    }
}