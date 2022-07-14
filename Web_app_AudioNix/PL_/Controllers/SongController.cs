using AutoMapper;
using BL.Services.Implementations;
using DL;
using Microsoft.AspNetCore.Mvc;
using PL.Mapping;
using PL.Models;

namespace PL.Controllers
{
    public class SongController : Controller
    {
        private readonly ILogger<SongController> _logger;
        private readonly IMapper _mapper;


        List<SongView> songViews;

        SongIMP songIMP;


        private ApplicationContext db;

        public SongController(ApplicationContext db, ILogger<SongController> logger)
        {
            _logger = logger;

            this.db = db;

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfilePL_BL());
            });

            _mapper = mappingConfig.CreateMapper();
            songIMP= new SongIMP(db);
        }

        [HttpGet]
        public async Task<IActionResult> SongList()
        {
            return View(songViews = _mapper.Map<List<SongView>>(await songIMP.GetAll()));
        }

        [HttpGet]
        public IActionResult AddSong()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddSong(string Name_of_song,string Source,string Picture, DateTime Date_of_Release )
        {
            Picture = "/Images/" + Picture;
            Source = "/Songs/" + Source;
            songIMP.AddSong(Name_of_song, Source, Picture, Date_of_Release);

            return View();
        }
    }
}
