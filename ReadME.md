# About Web Api
I developed this web api project for a online phonebook. It is working via phone number. Token Authorization is working with user from **Tbl_WebApi_Users** Because of that, you should add a user for authentication when you run it first. After token authorization, you can access all methods. I added swagger for easy to use. 

# Installation
Update database path from **DataAccess.Concrete.EntityFramework.DatabaseContext** file and then run as follows command in DataAccess project root path.

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

After take success from those commands, you can run api from WebApi folder.

# How To Use
After create a user, you should take token for authorization. After take a authorization, you should add it as header. You can use Authorization button for it on swagger page. 

Example: **Bearer YOURTOKEN**

After logged in, you can test all methods. 