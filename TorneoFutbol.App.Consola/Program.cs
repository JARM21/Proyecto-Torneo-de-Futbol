//using Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Consola
{
    class Program
    {
        //private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico(new Persistencia.AppContext());
        private static IRepositorioEquipos _repoEquipo = new RepositorioEquipos(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddEquipos();
            //AddDirectoresTecnicos();
            //BuscarDirectoresTecnicos(1);

        }

        /*private static void AddDirectoresTecnicos()
        {
            var DirectoresTecnicos = new DirectoresTecnicos
            {
                Nombre = "Isabella",
                Documento = "1232444",
                Telefono = "318943572"
            };

            _repoDirectorTecnico.AddDirectoresTecnicos(DirectoresTecnicos);
        }

        private static void BuscarDirectoresTecnicos(int IdDirectoresTecnicos)
        {
            var DirectoresTecnicos = _repoDirectorTecnico.GetDirectoresTecnicos(IdDirectoresTecnicos);
            Console.WriteLine(DirectoresTecnicos.Nombre + " " + DirectoresTecnicos.Documento);
        }
        */
        
        private static void AddEquipos()
        {
            var Equipos = new Equipos
            {
                Nombre = "Aguilas Doradas",
                CantidadPartidosJugados = 0,
                CantidadPartidosEmpatados = 0,
                GolesAFavor = 0,
                GolesEnContra = 0,
                Puntos = 0
                
            };

            _repoEquipo.AddEquipos(Equipos);
        }
    }

}
