using Microsoft.Net.Http.Headers;

namespace apidotnet.Models;


public class Pelicula
{
    public int PeliculaId { get; set;}

    public string Titulo { get; set;} = "Sin titulo";

    public string Sinopsis { get; set;} = "Sin sinopsis";

    public int Anio { get; set;}

    public string Poster { set; get;} = "N/A";

    public ICollection<Categoria>? Categorias { get; set;}

}