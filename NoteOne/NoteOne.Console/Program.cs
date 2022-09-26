// See https://aka.ms/new-console-template for more information
using NoteOne.Infrastructure.Repositories;

UserRepository userRepo = new UserRepository();
userRepo.Get(Guid.Parse("50a22f3f-d7c3-4950-baea-f37915615005"));
Console.WriteLine("Hello, World!");
