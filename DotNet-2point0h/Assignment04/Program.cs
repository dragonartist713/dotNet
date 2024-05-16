using System.Text.Json;
using System;
using System.IO;
using Components;
using Models;
using Interfaces;
using Services;

namespace Assignment04
{

    class Program
    {
        static void Main(string[] args)
        {
            //Your Program.cs file will be quite simple. All it needs to do is read the JSON data into the program, 
            string baseDir = Directory.GetCurrentDirectory();
            // Console.WriteLine(baseDir);
            
            string jsonFilePath = baseDir + "\\TvShows.json";
            var json = File.ReadAllText(jsonFilePath);

            var options = new JsonSerializerOptions { 
                PropertyNameCaseInsensitive = true 
            };
            string path = writer.WriteDirPath;
            string currentDir = Directory.GetCurrentDirectory();
            currentDir = Directory.SetCurrentDirectory(path);
            List<TvShow> allshows = JsonSerializer.Deserialize<List<TvShow>>(json, options);
            //instantiate an instance of the SiteGenerator,
            SiteGenerator website = new SiteGenerator(baseDir, currentDir, allshows);
            //and then call the GeneratePages() method on that instance in order to create the web pages for all of the TvShow’s in the JSON data provided.
            website.GeneratePages();
        }
    }
}