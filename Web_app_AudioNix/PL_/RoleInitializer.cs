using DL.Entities;
using Microsoft.AspNetCore.Identity;

namespace PL
{
    public class RoleInitializer
    {
    
        public RoleInitializer() { 
        }
        public static async Task InitializeUserAsync(User user, UserManager<User> _userManager, RoleManager<IdentityRole> _roleManager)
        {

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, "user");
            }

        }

        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "maximbozhik@yandex.ua";
            string password = "Maxim2000%";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin, password);

                if (result.Succeeded)
                {
                    Console.WriteLine("RESULT:  " + admin.Email);
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}
