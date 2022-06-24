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

            genreViews = _mapper.Map<List<GenreView>>(genreIMP.GetAll());
        }

        [HttpGet]
        public IActionResult GenreList()
        {
            return View(genreViews);
        }

        [HttpGet]
        public IActionResult AddGenre()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditGenre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGenre(string Name_of_genre)
        {
            genreIMP.AddGenre(Name_of_genre);

            return View();
        }


        [HttpPost]
        public IActionResult EditGenre(GenreView item)
        {
            var genre = _mapper.Map<GenreDTO>(item);

            genreIMP.EditGenre(genre);

            return View();
        }

        [HttpPost]
        public IActionResult DeleteGenre(GenreView item)
        {
            var genre = _mapper.Map<GenreDTO>(item);

            genreIMP.RemoveGenre(genre);

            return View();
        }
    }
}
