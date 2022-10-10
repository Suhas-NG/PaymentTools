using NoteOne.Application.Categories.Commands.CreateCategory;
using NoteOne.Application.Categories.Commands.CreateCategory.Factory;
using NoteOne.Application.Categories.Commands.CreateNote;
using NoteOne.Application.Categories.Commands.CreateNote.Factory;
using NoteOne.Application.Categories.Commands.CreatePage;
using NoteOne.Application.Categories.Commands.CreatePage.Factory;
using NoteOne.Application.Categories.Queries;
using NoteOne.Application.Interfaces;
using NoteOne.Common;
using NoteOne.Common.Dates;
using NoteOne.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Queries
builder.Services.AddTransient<IGetUserCategoriesQuery, GetUserCategoriesQuery>();

//comamnds
builder.Services.AddTransient<ICreateCategoryCommand, CreateCategoryCommand>();
builder.Services.AddTransient<ICreatePageCommand, CreatePageCommand>();
builder.Services.AddTransient<ICreateNoteCommand, CreateNoteCommand>();

//factories
builder.Services.AddTransient<ICategoryFactory, CategoryFactory>();
builder.Services.AddTransient<IPageFactory, PageFactory>();
builder.Services.AddTransient<INoteFactory, NoteFactory>();

//common services
builder.Services.AddTransient<IDateService, DateService>();

//Repositories
builder.Services.AddTransient<INoteRepository, NoteRepository>();
builder.Services.AddTransient<IPageRepository, PageRepository>();
builder.Services.AddTransient<IUserRespository, UserRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICreateCategoryCommand, CreateCategoryCommand>();
builder.Services.AddTransient<IGetUserCategoriesQuery, GetUserCategoriesQuery>();

// Add services to the container.

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
app.UseAuthorization();
app.MapControllers();
app.Run();
