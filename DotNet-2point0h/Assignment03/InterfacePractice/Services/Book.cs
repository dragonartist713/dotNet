using Interfaces;

namespace Services{
    class Book: IPrintable{
        public string Title {get; set;}
        public string Author {get; set;}
        public string Genre {get; set;}

        public void PrintDetails(){
            Console.WriteLine($"Book: {this.Title} by {this.Author}, Genre: {this.Genre}");
        }
    }
}