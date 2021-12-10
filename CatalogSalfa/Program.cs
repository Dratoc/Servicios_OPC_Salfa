using CatalogSalfa.Services;
using CatalogSalfa.ServicesInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IToken, TokenService>();
builder.Services.AddSingleton<IWorkspace, WorkspaceService>();
builder.Services.AddSingleton<IActivity, ActivityService>();
builder.Services.AddSingleton<IProject, ProjectService>();
builder.Services.AddSingleton<IWorkManagerTask, WorkManagerTaskService>();
builder.Services.AddSingleton<IUser, UserService>();
builder.Services.AddSingleton<IWorkManagerTaskCommitment, WorkManagerTaskCommitmentService>();
builder.Services.AddSingleton<IConstraint, ConstraintService>();
builder.Services.AddSingleton<IReporteOPC_WM, ReporteOPC_WMService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
