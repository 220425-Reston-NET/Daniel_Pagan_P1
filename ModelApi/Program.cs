using ModelBL;
using ModelDL;
using ModelGundam;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepository>(repo => new SQLCustomerRepository(builder.Configuration.GetConnectionString("Daniel Pagan")));
builder.Services.AddScoped<ICustomerBL, CustomerBL>();
builder.Services.AddScoped<IRepository<CustomersModelsJoin>, SQLCustomersModelsJoinRepo>(repo => new SQLCustomersModelsJoinRepo(builder.Configuration.GetConnectionString("Daniel Pagan")));
builder.Services.AddScoped<ICustomersModelsJoinBL, CustomersModelsJoinBL>();

var app = builder.Build();

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
