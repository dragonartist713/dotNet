using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Services;
using System;
using System.Collections.Generic;

ServiceProvider _serviceProvider;
SeedingService _seedingService;
// DatabaseService _dbService;
// BasicQueryService _basicQueryService;


var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<SeedingService>();
// services.AddScoped<DatabaseService>();
// services.AddScoped<BasicQueryService>();

_serviceProvider = services.BuildServiceProvider();
_seedingService = _serviceProvider.GetRequiredService<SeedingService>();
// _dbService = _serviceProvider.GetRequiredService<DatabaseService>();
// _basicQueryService = _serviceProvider.GetRequiredService<BasicQueryService>();

_seedingService.SeedDatabase();