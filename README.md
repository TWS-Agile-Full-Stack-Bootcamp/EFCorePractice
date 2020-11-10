# Requirement
* please forked this repo for practice
* use Entity Framework Core to implement GET /companies and POST /companies

# Practice Output & Submit
* submit your git repo url to field `answer`

# hint
* you can follow these steps
* add `Pomelo.EntityFrameworkCore.MySql` reference
* use model
* MySql Connection string: `server=localhost;user=root;database=db;password=*****;`
* Use below code to method of `Configure` in file `Startup.cs` to create database automaticlly
```

using (var scope = app.ApplicationServices.CreateScope())
{
    using (var context = scope.ServiceProvider.GetService<CompanyDBContext>())
    {
        context.Database.EnsureCreated();
    }
}
```
* create database context
* inject database context then call its save & findAll in resource



