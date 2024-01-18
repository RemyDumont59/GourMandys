using backgourmandys.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.InjectDependancies();

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

app.UseCors(options =>
{
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

app.UseHttpsRedirection();

// app.useAuthentication(); // ACTIVE CE PUTAIN DE TRUC POUR l'AUTHENTICATION BIDULE !!!
app.UseAuthorization();

app.MapControllers();

app.Run();
