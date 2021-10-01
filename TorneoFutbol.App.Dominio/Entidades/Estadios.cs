namespace TorneoFutbol.App.Dominio
{
   
    public class Estadios
    {

        // Identificador del estadio
        public int Id { get; set; }
        // Nombre del estadio 
        public string Nombre { get; set; }
        // Dirección del estadio
        public string Direccion { get; set; }
        // Municipio al que pertenece 
        public Municipios Municipio { get; set; } 
    }
}