using FileIOJson.Models;

public class EmployeeWriter {
    public string WritePath {get; set;}
    public EmployeeWriter (string writePath){
        this.WritePath = writePath;
    }

    public void Write(Employee emp, EmployeeOptions? options = null){
        //if the directory at writepath does not exist, create it.
        Directory.CreateDirectory(this.WritePath);

        //once the directory exists, move into that directory.
        Directory.SetCurrentDirectory(this.WritePath);

        //while in the directory, create a file name which is a text file having the name of the employees id.
        string fileName = $"{emp.Id}.txt";

        //write out all the employees info except for the position and benefits.
        string contents = @$"
        ID: {emp.Id}
        Full Name: {emp.FullName}
        Annual Salary: {emp.AnnualSalary}";

        if(options == null){
            options = new EmployeeOptions();
        }

        if(options.IncludePosition){
            contents += @$"
            Position
            ------------
            Position ID: {emp.Position.Id}
            Position Description:{emp.Position.Description}";
        }

        if(options.IncludeBenefits){
            contents += @$"
            Benefits
            ------------
            Benefit ID: {emp.Position.Id}
            Benefit Description:{emp.Position.Description}";

            foreach(Benefit benefit in emp.Benefits){
                contents += @$"
                Description:{benefit.Description}
                Additional Benefit: {benefit.Additional}";
            }
        }

        File.WriteAllText(fileName, contents);
        
        //after you have written all of the info to the file, move back one directory
        Directory.SetCurrentDirectory("..");

    }

    public void WriteAll(List<Employee> employees, EmployeeOptions? options){
        //writes out all employees passed to the writepath
        foreach(Employee emp in employees){
            this.Write(emp, options);
        }
    }
}