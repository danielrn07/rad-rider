using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RadRiderWebApp.Data;
using RadRiderWebApp.Services;
using RadRiderWebApp.Services.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddNToastNotifyToastr(new ToastrOptions()
{
    ProgressBar = true,
    PositionClass = ToastPositions.TopRight
});

builder.Services.AddTransient<ISkateService, SkateService>();
builder.Services.AddDbContext<SkateDbContext>();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();