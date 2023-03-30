using ECommerceProject.DataAccess.Concrete.EntityFramework;
using ECommerceProject.Entities.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ECommerceProjectContext>();  //
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ECommerceProjectContext>();  //

builder.Services.AddControllersWithViews();

builder.Services.AddMvc(config =>  //
{
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();  //

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

//app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
app.UseAuthentication();   //

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
