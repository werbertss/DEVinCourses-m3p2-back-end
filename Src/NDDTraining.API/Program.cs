
using NDDTraining.DI.IOC;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
EmailIOC.RegisterServices(builder.Services);

var app = builder.Build();
app.UseCors(opcoes => opcoes.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
