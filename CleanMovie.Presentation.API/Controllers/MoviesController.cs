using CleanMovie.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieservice)
        {
            _movieService = movieservice;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var allmovies = _movieService.GetAllMovies();

            return Ok(allmovies);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAMovies([FromRoute] int id)
        {
            var themovie = _movieService.GetMovieById(id);

            return Ok(themovie);
        }
    }
}
