using Interfaces;

namespace Services{
    class Circle: IMeasurable{
        public double Radius {get; set;}
        
        public decimal CalculateArea(){
            decimal radius = Convert.ToDecimal(this.Radius);
            decimal pi = Convert.ToDecimal(Math.PI);
            return (pi * (radius * radius));
        }
        public decimal CalculatePerimeter(){
            decimal radius = Convert.ToDecimal(this.Radius);
            decimal pi = Convert.ToDecimal(Math.PI);
            return (2 * (pi * radius));
        }
    }
}