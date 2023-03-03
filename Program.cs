using DigitaliaFreelanceAPI.Context;
using DigitaliaFreelanceAPI.Repositories;
using DigitaliaFreelanceAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<IReceiptsService, ReceiptsService>();
builder.Services.AddHttpClient<IReceiptsService, ReceiptsService>();
builder.Services.AddTransient<IReceiptsRepository, ReceiptsRepository>();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new() {
        Title = "DigitaliaFreelanceAPI",
        Version = "v1",
        Description = "An .NET Core Web API for registering receipts for freelancers"
    });
});
builder.Services.AddCors(options => options.AddPolicy(name: "FreelancerOrigins", policy => {
    policy.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
    policy.WithOrigins("https://develop--astounding-gumption-9226af.netlify.app/").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("FreelancerOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
