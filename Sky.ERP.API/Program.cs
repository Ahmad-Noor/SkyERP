using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using Sky.ERP.Domain.Interfaces;
using Sky.ERP.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();

/*---------------------------------------------------------------------------------------------------*/
/*                                   Enable CORS                                                     */
/*---------------------------------------------------------------------------------------------------*/
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


////JSON Serializer
///Microsoft.AspNetCore.Mvc.NewtonsoftJson
//builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
//options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
//    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
//    = new DefaultContractResolver());
builder.Services.AddDatabaseConectionStrings(builder.Configuration);
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

/*---------------------------------------------------------------------------------------------------*/
/*                                      Swagger                                                      */
/*---------------------------------------------------------------------------------------------------*/
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Sky.ERP.API", Version = "v1" });
});
/*---------------------------------------------------------------------------------------------------*/
/*                                 JWT AUTHENTICATION SERVICE                                        */
/*---------------------------------------------------------------------------------------------------*/








var app = builder.Build(); 

//Enable CORS
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
 
// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sky.ERP.API v1"));
}


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
