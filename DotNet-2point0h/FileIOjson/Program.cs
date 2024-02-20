using System.Text.Json;
using FileIOJson.Models;

const string jsonFile = "./company_info.json";
string json = File.ReadAllText(jsonFile);

var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

// JSON.parse()
Company companyA = JsonSerializer.Deserialize<Company>(json, options);

const string employeeDir = "employees_directory";
EmployeeWriter writer = new EmployeeWriter(employeeDir);

writer.WriteAll(companyA.Employees);