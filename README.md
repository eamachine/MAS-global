# MASGlobalTest

.NET core 2 MVC project

Simple WEB app, .NET project,
getEmployees gets data from  http://masglobaltestapi.azurewebsites.net/swagger/

Above a summary of the structure

Data layer, DTO Employee, Employee repository implemented, Data Model Employee, 2 different kinds of employees extended
Business layer, get data, and exposes methods to get and filter data
Employee Controller, exposes getEmployees method for Angular project

( not Injection Dependency, IoC implemented yet )

Test project tests basic EmployeeManager Functionalities, get data and filter

Angular

basic project, it shows a table with the results and let execute a basic filtering  
