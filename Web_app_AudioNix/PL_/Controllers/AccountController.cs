using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.DtoEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PL.Models.AccountViewModels;
using PL.Models;
using AutoMapper;
using BL.Services.Implementations;
using DL;
using PL.Mapping;
using DL.Entities;

namespace PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        UserIMP userIMP;

        private ApplicationContext db;

        public AccountController(ApplicationContext db, ILogger<HomeController> logger, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            this.db = db;
            
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfilePL_BL());
            });

            _mapper = mappingConfig.CreateMapper();

            userIMP = new UserIMP(db);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegisterViewModel model)
        {
            //await userIMP.AddUser(model.Login, model.Password,model.Email,model.Picture);
            if (ModelState.IsValid)
            {

                User user = new User { UserName = model.Login, Email = model.Email, Password = model.Password, Picture = model.Picture };
          
            
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
         


            return View(model);
        }
    }
}
