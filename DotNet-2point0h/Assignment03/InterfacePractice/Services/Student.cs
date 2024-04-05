using Interfaces;

namespace Services{
    class Student: IPrintable{
        public string Name {get; set;}
        public string Age {get; set;}
        public string Major {get; set;}

        public void PrintDetails(){
            Console.WriteLine($"Student: {this.Name}, Age: {this.Age}, Major: {this.Major}");
        }
    }
}