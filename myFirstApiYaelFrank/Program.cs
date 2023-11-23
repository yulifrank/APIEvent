
using myFirstApiYaelFrank;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("myPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddSingleton<DataContext>();
builder.Services.AddSingleton<IDataContext, DataContext>();//����� �����
//builder.Services.AddTransient<IDataContext, DataContext>();//����� �����
//builder.Services.AddScoped<IDataContext, DataContext>();//����� �����

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("myPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
