using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Security.Encryption;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});

//auth
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<Core.Utilities.Security.JWT.TokenOptions>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<IBrandDal, EfBrandDal>();
builder.Services.AddScoped<ICarService, CarManager>();
builder.Services.AddScoped<ICarDal, EfCarDal>();
builder.Services.AddScoped<IColorService, ColorManager>();
builder.Services.AddScoped<IColorDal, EfColorDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<IRentalService, RentalManager>();
builder.Services.AddScoped<IRentalDal, EfRentalDal>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IFileHelper, FileHelperManager>();
builder.Services.AddScoped<ICarImageService, CarImageManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
