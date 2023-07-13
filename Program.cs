using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(cors =>{
    cors.AddPolicy("PublicPolicy", settings =>
    {
        settings.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});
builder.Services.AddControllers();
builder.Services.AddDbContext<ECommerceContext>
    ( options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerce"));

    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//////////////////////////////////////////////////////////////////////////////////////////////
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("PublicPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
