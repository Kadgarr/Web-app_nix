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
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
      
            if (ModelState.IsValid)
            {
                
                var result = await _signInManager.PasswordSignInAsync(model.Login, model.Password, model.RememberMe, false);
                
                if (result.Succeeded)
                {
                   
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный адресс электронной почты и (или) пароль");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout(string returnUrl = null)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
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

                User user = new User {Id= Guid.NewGuid().ToString(), UserName = model.Login, Email = model.Email, Password = model.Password, Picture = model.Picture, Date_of_registration=DateTime.Today };
          
            
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
        [HttpGet]
        public async Task<IActionResult> Profile(string name)
        { 
            //var user = _mapper.Map<UserView>(await _userManager.FindByNameAsync(name));
            var user = await _userManager.FindByNameAsync(name);

            var userDTO = _mapper.Map<UserDTO>(await userIMP.GetItemAsync(user.Login));

            var userView = _mapper.Map<UserView>(userDTO);

            if (userView == null)
            {
                return NotFound();
            }

            return View(userView);
        }


        [HttpGet]
        public async Task<IActionResult> EditProfile(string name)
        {
            var user = await _userManager.FindByIdAsync(name);

            var userDTO = _mapper.Map<UserDTO>(await userIMP.GetItemAsync(user.Login));

            var userView = _mapper.Map<UserView>(userDTO);

            if (userView == null)
            {
                return NotFound();
            }

            return View(userView);
        }


        [HttpPost]
        public async Task<IActionResult> EditProfile(UserView getuser)
        {
            Console.WriteLine("======ID ПОЛЬЗОВАТЕЛЯ======= :" + getuser.Email);
            User user = await _userManager.FindByIdAsync(getuser.Id);
            if (ModelState.IsValid)
            {
           
                if (user != null)
                {
                    //var userDTO = await userIMP.GetItemAsync(getuser.Login);
                    user.Email = getuser.Email;
                    //user.UserName = getuser.UserName;
                    user.Picture = getuser.Picture;
                    user.Password = getuser.Password;
                    user.UserName = getuser.Login;
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction("Index", "Home");


                }
            }
            
            return RedirectToAction("Index","Home");


        }

    }
}
