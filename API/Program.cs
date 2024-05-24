using Data.Connection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbConnection>();
builder.Services.AddControllers();
//builder.Services.AddScoped<>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
