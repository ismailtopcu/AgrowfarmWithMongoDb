using AgrowFarmProject.Services.About;
using AgrowFarmProject.Services.Banner;
using AgrowFarmProject.Services.OurService;
using AgrowFarmProject.Services.Statistic;
using AgrowFarmProject.Services.Testimonial;
using AgrowFarmProject.Services.VideoBanner;
using AgrowFarmProject.Services.WhyUs;
using AgrowFarmProject.Settings;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IOurServiceService, OurServiceService>();
builder.Services.AddScoped<IStatisticService, StatisticService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IVideoBannerService, VideoBannerService>();
builder.Services.AddScoped<IWhyUsService, WhyUsService>();

builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
	return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
