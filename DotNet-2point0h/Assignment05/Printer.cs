public class Printer{
    public T Print<T>(T first, T second) {
        Console.WriteLine("Value 1: " + first + " | Value 2: "+ second);
        return first;
    }

}