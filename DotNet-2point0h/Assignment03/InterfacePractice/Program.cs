// See https://aka.ms/new-console-template for more information
using Interfaces;
using Services;

Book asue10 = new Book{
    Title = "The Slippery Slope",
    Author = "Lemony Snicket",
    Genre = "Young Adult Fiction"
};

Student me = new Student{
    Name = "Lindsay",
    Age = "34",
    Major = "Web/Software Dev"
};

asue10.PrintDetails();
me.PrintDetails();

BasicCalculations calc = new BasicCalculations();

Console.WriteLine(calc.Add(1,2));
Console.WriteLine(calc.Subtract(5,2));

Circle round = new Circle{
    Radius = 7
};

Rectangle square = new Rectangle{
    Length = 7,
    Width = 13
};

Console.WriteLine(round.CalculateArea());
Console.WriteLine(round.CalculatePerimeter());
Console.WriteLine(square.CalculateArea());
Console.WriteLine(square.CalculatePerimeter());
