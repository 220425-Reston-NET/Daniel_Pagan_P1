using ModelBL;
using ModelDL;
using ModelGundam;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// This is the connection to the SQLCustomerRepository (builder.Configuration.GetConnectionString("Daniel Pagan")
// This is the connection to the SQLCustomersModelsJoinRepo (builder.Configuration.GetConnectionString("Daniel Pagan")   
// This is the connection to the SQLModelRepository (builder.Configuration.GetConnectionString("Daniel Pagan")


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepository>(repo => new SQLCustomerRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<ICustomerBL, CustomerBL>();
builder.Services.AddScoped<IRepository<CustomersModelsJoin>, SQLCustomersModelsJoinRepo>(repo => new SQLCustomersModelsJoinRepo(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<ICustomersModelsJoinBL, CustomersModelsJoinBL>();
builder.Services.AddScoped<IRepository<Model>, SQLModelRepository>(repo => new SQLModelRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<IModelBL, ModelBusinessLayer>();
builder.Services.AddScoped<IRepository<ModelAbiJoin>, SQLModelAbiJoinRepository>(repo => new SQLModelAbiJoinRepository(builder.Configuration.GetConnectionString("Daniel Pagan")));
builder.Services.AddScoped<IModelAbiJoinBL, ModelAbiJoinBL>();
builder.Services.AddScoped<IRepository<Store>, SQLStoreRepository>(repo => new SQLStoreRepository(builder.Configuration.GetConnectionString("Daniel Pagan")));
builder.Services.AddScoped<IStoreBL, StoreBL>();

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
