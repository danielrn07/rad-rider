using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RadRiderWebApp.Data;
using RadRiderWebApp.Services;
using RadRiderWebApp.Services.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options => {
        options.Conventions.AuthorizeFolder("/Brands");
        options.Conventions.AuthorizeFolder("/Categories");
        options.Conventions.AuthorizeFolder("/SkateModels");
        options.Conventions.AuthorizeFolder("/Tags");
    })
    .AddNToastNotifyToastr(new ToastrOptions()
    {
        ProgressBar = true,
        PositionClass = ToastPositions.TopRight
    });

builder.Services.AddTransient<ISkateService, SkateService>();
builder.Services.AddDbContext<SkateDbContext>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<SkateDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var context = new SkateDbContext();
context.Database.Migrate();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseNToastNotify();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();