# About Project
I developed this web api project for a online phonebook. It is working via phone number. After token authorization, you can access all methods. I added swagger for easy to use. 

# Installation
Update database path from [DataAccess.Concrete.EntityFramework.DatabaseContext] file and then run as follows command in DataAccess project root path.

```bash
dotnet ef migrations add InitialDatabase
dotnet ef database update
```

After this two command, you should run as follows command on your Web Api project root path. 

```bash
dotnet clean
dotnet restore
dotnet build
```

You can run api from WebApi folder.