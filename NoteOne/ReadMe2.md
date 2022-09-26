Choose persistence as the project.
Add-Migration [-Name] <String> [-OutputDir <String>] [-Context <String>] [-Project <String>] [-StartupProject <String>] 
    [-Namespace <String>] [-Args <String>] [<CommonParameters>]


1.)Add-Migration -Name initial -StartupProject NoteOne.Persistence

->Results in migration.cs files 

2.) Update database direct: dotnet ef database update -StartupProject NoteOne.Persistence
    -> direct migration from migration.cs to db
2.) Create script: Script-migration -StartupProject NoteOne.Persistence
    -> Read migration and saves sql file 
3.) Update database: Update-database -StartupProject NoteOne.Persistence


    Important Links
    https://www.entityframeworktutorial.net/efcore/cli-commands-for-ef-core-migration.aspx


============================================
Dotnet Commands


**Migrations**
Install 
-> Microsoft.EntityFrameworkCore 
-> Microsoft.EntityFrameworkCore.Design
-> NpSql.

1.) dotnet ef migrations add InitialCreate -s NoteOne.persistence -p NoteOne.Persistence
2.) dotnet ef  database update -s NoteOne.persistence -p NoteOne.Persistence
3.) dotnet ef migrations add AddEmailToUser -s NoteOne.persistence -p NoteOne.Persistence
