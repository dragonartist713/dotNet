using System.Text.Json;
using System;
using System.IO;
using static Assignment02.TvShowWriter;


namespace Assignment02
{

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("=================== PROMPT 1 BEGIN ===================");
        //Create an instance of TvShowWriter with a specific write directory path. Verify that the directory exists after initialization.
        string currentDir = Directory.GetCurrentDirectory();
        TvShowWriter writer = new TvShowWriter(currentDir, "TV-Shows");
        string jsonFilePath = currentDir + "\\TvShows.json";
        var json = File.ReadAllText(jsonFilePath);

        var options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
        List<TvShow> allshows = JsonSerializer.Deserialize<List<TvShow>>(json, options);
        Console.WriteLine($"Current Directory: {currentDir}");

        Console.WriteLine("=================== PROMPT 1 END ===================\n");


        Console.WriteLine("=================== PROMPT 2 BEGIN ===================");
        //Extract a single TvShow object from the data and use the Write method to save its details to a text file in a location of your choosing. Verify that the file exists and contains the correct content.
        Directory.SetCurrentDirectory(writer.WriteDirPath);
        writer.Write(allshows[0]);
        Console.WriteLine($"File Created for {allshows[0].id}.");
        // foreach(TvShow show in allshows){
        //     writer.Write(show);
        // }
        

        Console.WriteLine("=================== PROMPT 2 END ===================\n");


        Console.WriteLine("=================== PROMPT 3 BEGIN ===================");
        //After using the Write method, call MoveToBaseDir and verify that the current directory has been correctly changed back to the base directory.
        
        writer.MoveToBaseDir();
        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

        Console.WriteLine("=================== PROMPT 3 END ===================\n");


        Console.WriteLine("=================== PROMPT 4 BEGIN ===================");
        //Given a list of TvShow objects with varying OriginCountry values, use CreateCountryDirectories to create directories for each unique country. Verify that no duplicate directories are created.
        
        int count = writer.CreateCountryDirectories(allshows, "Countries");
        Console.WriteLine($"Number of Directories Created: {count}");

        Console.WriteLine("=================== PROMPT 4 END ===================\n");


        Console.WriteLine("=================== PROMPT 5 BEGIN ===================");
        //After calling CreateCountryDirectories, verify that when returnToBasePath is true, the current working directory is set back to the base directory.
        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

        Console.WriteLine("=================== PROMPT 5 END ===================\n");


        Console.WriteLine("=================== PROMPT 6 BEGIN ===================");
        //Utilize WriteShowsByCountry with a list of TvShow objects to create directories for each country and write files for shows corresponding to their origin country. Verify the correct organization of directories and files.

        writer.WriteShowsByCountry(allshows, "Countries");
        Console.WriteLine($"Number of Files Created: {allshows.Count}");

        Console.WriteLine("=================== PROMPT 6 END ===================\n");
        }
    }
}