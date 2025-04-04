using AutoMapper;
using Challenge.Suris.Business.Services;
using Challenge.Suris.Data;
using Challenge.Suris.Domain.Interfaces;
using Mango.Services.OrderAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins(builder.Configuration.GetValue<string>("AllowedOrigins")!)
                                .AllowAnyHeader()
                                .AllowAnyMethod(); ;
                      });
});

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IReservationDAO, ReservationDAO>();

builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<IServiceDAO, ServiceDAO>();

builder.Services.AddScoped<IScheduleService, ScheduleService>();
builder.Services.AddScoped<IScheduleDAO, ScheduleDAO>();

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

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
