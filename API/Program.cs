using Business.Manager;
using Business.Service;
using Data.Connection;
using Data.DAL;
using Data.Repositories;
using DTO.AutoMapper;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbConnection>();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDAL,CategoryRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDAL, ProductRepository>();
builder.Services.AddScoped<IContactUsService, ContactUsManager>();
builder.Services.AddScoped<IContactUsDAL, ContactUsRepository>();
builder.Services.AddScoped<ISubscriberService, SubscriberManager>();
builder.Services.AddScoped<ISubscriberDAL, SubscriberRepository>();
builder.Services.AddScoped<IEmailService, EmailManager>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(CategoryMapper));
builder.Services.AddAutoMapper(typeof(ProductMapper));
builder.Services.AddAutoMapper(typeof(ContactUsManager));
builder.Services.AddAutoMapper(typeof(SubscriberMapper));
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
