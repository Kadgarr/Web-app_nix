using Microsoft.AspNetCore.Mvc;
using DL.Entities;
using AutoMapper;
using PL.Models;
using PL.Mapping;
using DL;
using BL.Services.Implementations;
using BL.DtoEntities;
namespace PL.Controllers
{
    public class GenreController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;


        List<GenreView> genreViews;

        GenreIMP genreIMP;


        private ApplicationContext db;


        public GenreController(ApplicationContext db, ILogger<HomeController> logger)
        {
            _logger = logger;

            this.db = db;

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfilePL_BL());
            });

            _mapper = mappingConfig.CreateMapper();

            genreIMP = new GenreIMP(db);

            
        }

        [HttpGet]
        public async Task<IActionResult> GenreList()
        {
            return View(genreViews = _mapper.Map<List<GenreView>>(await genreIMP.GetAll()));
        }

        [HttpGet]
        public IActionResult AddGenre()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditGenre(Guid id)
        {
            var genre = _mapper.Map<GenreView>(await genreIMP.GetItemAsync(id));
            return View(genre);
        }

        [HttpPost]
        public IActionResult AddGenre(string Name_of_genre)
        {
            genreIMP.AddGenre(Name_of_genre);

            return View();
        }


        [HttpPost]
        public async Task<ActionResult> EditGenre(Guid GenreId, string Name_of_Genre)
        {
            var item = _mapper.Map<GenreView>(await genreIMP.GetItemAsync(GenreId));

            var genre = _mapper.Map<GenreDTO>(item);

            genre.Name_of_Genre = Name_of_Genre;

            await genreIMP.EditGenre(genre);

            return View();
        }

        [HttpPost]
        [ActionName("GenreList")]
        public async Task<IActionResult> DeleteGenre(Guid id)
        {
            var list = _mapper.Map<List<GenreView>>(await genreIMP.GetAll());

            var item = list.FirstOrDefault(x=>x.GenreId==id);

            var genre = _mapper.Map<GenreDTO>(item);

            await genreIMP.RemoveGenre(genre);

            return View("GenreList", genreViews =  _mapper.Map<List<GenreView>>(await genreIMP.GetAll()));
        }
    }
}
