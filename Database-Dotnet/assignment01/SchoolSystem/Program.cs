using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Services;
using System;
using System.Collections.Generic;

ServiceProvider _serviceProvider;
SeedingService _seedingService;

BasicQueryService _basicQueryService;


var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<SeedingService>();
services.AddScoped<BasicQueryService>();

_serviceProvider = services.BuildServiceProvider();
_seedingService = _serviceProvider.GetRequiredService<SeedingService>();

_basicQueryService = _serviceProvider.GetRequiredService<BasicQueryService>();

_seedingService.SeedDatabase();

Console.WriteLine("============ NUMBER 1 - GetAllInstructorNames() ===================");
// TODO: Call GetAllInstructorNames() and then print the results.

_basicQueryService.GetAllInstructorNames().ForEach(Console.WriteLine);


Console.WriteLine("============ NUMBER 2 - GetStudentsInCourse() ===================");
// TODO: Call GetStudentsInCourse() and then print the results for a specific course.
_basicQueryService.GetStudentsInCourse("Calculus").ForEach(Console.WriteLine);

Console.WriteLine("============ NUMBER 3 - GetDepartmentsWithCourses() ===================");
// TODO: Call GetDepartmentsWithCourses() and then print the results.
_basicQueryService.GetDepartmentsWithCourses().ForEach(Console.WriteLine);

Console.WriteLine("============ NUMBER 4 - GetDepartmentWithMostCourses() ===================");
// TODO: Call GetDepartmentWithMostCourses() and then print the result.


Console.WriteLine("============ NUMBER 5 - GetStudentsEnrolledInMoreThanFiveCourses() ===================");
// TODO: Call GetStudentsEnrolledInMoreThanFiveCourses() and then print the results.


Console.WriteLine("============ NUMBER 6 - GetCoursesByInstructor() ===================");
// TODO: Call GetCoursesByInstructor() with a specific instructor name and then print the results.


Console.WriteLine("============ NUMBER 7 - GetStudentsWithNoCourses() ===================");
// TODO: Call GetStudentsWithNoCourses() and then print the results.
_basicQueryService.GetStudentsWithNoCourses().ForEach(Console.WriteLine);

Console.WriteLine("============ NUMBER 8 - GetInstructorWithMostCourses() ===================");
// TODO: Call GetInstructorWithMostCourses() and then print the result.
