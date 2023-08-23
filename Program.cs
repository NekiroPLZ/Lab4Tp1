using Factory_Method.Repository;
using static Factory_Method.DroneAll;

var builder = WebApplication.CreateBuilder(args);

// Agrega la implementaci�n de IRepository como Singleton
builder.Services.AddSingleton<IDroneService, DroneService>();

// Agrega la configuraci�n de DroneServiceFactory con la inyecci�n de IRepository
builder.Services.AddSingleton<DroneServiceFactory>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//asdasdasd
app.UseAuthorization();

app.MapControllers();

app.Run();
