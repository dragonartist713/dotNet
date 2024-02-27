namespace InterfaceExamples.Models;
using InterfaceExamples.Interfaces;

public class Android: Phone, ISmartphone {
    public static string Browser {get;} = "Chrome";
    public List<string> Commands = new List<string>{"Ok Google", "Check e-mail"};
    public List<string> CommandActions = new List<string>{"Listening...", "Checking e-mail"};

    public void CallLarryPage(){
        Console.WriteLine("Calling Larry Page");
    }
}