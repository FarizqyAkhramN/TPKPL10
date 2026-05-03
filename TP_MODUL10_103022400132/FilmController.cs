using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400132;
namespace TP_MODUL10_103022400132
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static List<Film> daftarFilm = new List<Film>
        {
            new Film("Inception", "Christopher Nolan", "2010", "Sci-Fi", "9.0"),
            new Film("Interstellar", "Christopher Nolan", "2014", "Sci-Fi", "8.7"),
            new Film("Parasite", "Bong Joon-ho", "2019", "Thriller", "8.6")
        };

        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return daftarFilm;
        }

        [HttpGet("{index}")]
        public Film Get(int index)
        {
            return daftarFilm[index];
        }

        [HttpPost]
        public void Post([FromBody] Film filmBaru)
        {
            daftarFilm.Add(filmBaru);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            daftarFilm.RemoveAt(index);
        }
    }
}
