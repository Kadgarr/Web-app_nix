using BL.Mapping;
using DL;
using DL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PL;
using PL.Mapping;


var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("ApplicationContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationContextConnection' not found.");

//builder.Services.AddDbContext<ApplicationContext>(options =>
//    options.UseSqlServer(connectionString));;

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationContext>();;

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Web_app_AudioNix"), b =>
                    b.MigrationsAssembly("DL")));
builder.Services.AddScoped<ApplicationContext>();
builder.Services.AddScoped <RoleInitializer>();
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>();

//builder.Services.AddIdentity<User, IdentityRole>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile), typeof(AutoMapperProfilePL_BL));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
