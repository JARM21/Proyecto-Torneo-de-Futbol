using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext;
        public RepositorioDirectorTecnico(AppContext appContext)
        {
            _appContext=appContext;
        }

        DirectoresTecnicos IRepositorioDirectorTecnico.AddDirectoresTecnicos(DirectoresTecnicos DirectoresTecnicos)
        {
            var DirectorTecnicoAdicionado = _appContext.DirectoresTecnicos.Add(DirectoresTecnicos);
            _appContext.SaveChanges();
            return DirectorTecnicoAdicionado.Entity;
        }

        void IRepositorioDirectorTecnico.DeleteDirectoresTecnicos(int IdDirectoresTecnicos)
        {
            var DirectorTecnicoEncontrado=_appContext.DirectoresTecnicos.FirstOrDefault(m=>m.Id==IdDirectoresTecnicos);
            if(DirectorTecnicoEncontrado==null)
                return;
            _appContext.DirectoresTecnicos.Remove(DirectorTecnicoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<DirectoresTecnicos> IRepositorioDirectorTecnico.GetAllDirectoresTecnicos()
        {
            return _appContext.DirectoresTecnicos;
        }

        DirectoresTecnicos IRepositorioDirectorTecnico.GetDirectoresTecnicos(int IdDirectoresTecnicos)
        {
            return _appContext.DirectoresTecnicos.FirstOrDefault(m=>m.Id==IdDirectoresTecnicos);
            
        }

        DirectoresTecnicos IRepositorioDirectorTecnico.UpdateDirectoresTecnicos(DirectoresTecnicos DirectorTecnico)
        {
            var DirectorTecnicoEncontrado=_appContext.DirectoresTecnicos.FirstOrDefault(m=>m.Id==DirectorTecnico.Id);
            if(DirectorTecnicoEncontrado!=null)
            {
                DirectorTecnicoEncontrado.Nombre = DirectorTecnico.Nombre;
                DirectorTecnicoEncontrado.Documento = DirectorTecnico.Documento;
                DirectorTecnicoEncontrado.Telefono = DirectorTecnico.Telefono;
                _appContext.SaveChanges();
            }
            return DirectorTecnicoEncontrado;
        }
    }
}


