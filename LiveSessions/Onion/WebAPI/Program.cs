using Persistence;
using Application;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* katmanlarin bagimliliklarini kendilerinin ekledigi bir yapidayiz.
 * ornek olarak persistence katmanindaki bagimliliklarini extension metot
 * ile tersine (persistence > webapi) bagimlilik olmadan eklemis olduk.
 * her katman kendi bagimliliklarini kendisi eklemeli.
 */

builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();


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
