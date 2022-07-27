using AutoMapper;
using BL.Services.Implementations;
using DL;
using Microsoft.AspNetCore.Mvc;
using PL.Mapping;
using PL.Models;
using PL.Models.Pagination;

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
        public async Task<IActionResult> SongList(int page = 1)
        {

            int pageSize = 3;   // количество элементов на странице
            songViews = _mapper.Map<List<SongView>>(await songIMP.GetAll());
            var count =  songViews.Count;
            var items =  songViews.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Songs = items
            };
            return View(viewModel);
          
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
