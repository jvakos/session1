using ManolisShop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using MServer.Areas.Identity;
using MServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Database>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<Role>()
    .AddEntityFrameworkStores<Database>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<User>>();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

using (var db=new Database())
{
    bool firstTime=db.Database.EnsureCreated();
    if (firstTime)
    {
        db.Roles.Add(new Role { Name = "Admin", NormalizedName = "ADMIN" });
        db.Roles.Add(new Role { Name = "Client", NormalizedName = "CLIENT" });

        var adminUser = new User
        {
            Email = "info@manolishop.gr",
            NormalizedEmail = "INFO@MANOLISHOP.GR",
            UserName = "info@manolishop.gr",
            NormalizedUserName = "INFO@MANOLISHOP.GR",
            EmailConfirmed = true,
            SecurityStamp=new Guid().ToString(),
            Firstname = "Admin",
            Lastname = "Adminakis",
        };
        adminUser.PasswordHash = new PasswordHasher<User>().HashPassword(adminUser, "123!@#qweQWE");
        db.Users.Add(adminUser);
        db.SaveChanges();

        db.UserRoles.Add(new IdentityUserRole<int> { RoleId =1, UserId = 1});

        db.SaveChanges();

    }
}

app.Run();
