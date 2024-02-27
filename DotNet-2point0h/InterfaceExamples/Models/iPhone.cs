namespace InterfaceExamples.Models;
using InterfaceExamples.Interfaces;

public class iPhone: Phone, ISmartphone{
    public static string Browser {get;} = "Safari";
    public List<string> Commands = new List<string>{"Hey Siri", "Check Weather"};
    public List<string> CommandActions = new List<string>{"Listening...", "Displaying Weather"};

    public void CallSteveJobs(){
        Console.WriteLine("Calling Steve Jobs");
    }
}