using Interfaces;

namespace Services{
    class Rectangle: IMeasurable{
        public double Length {get; set;}
        public double Width {get; set;}
        
        public decimal CalculateArea(){
            decimal length = Convert.ToDecimal(this.Length);
            decimal width = Convert.ToDecimal(this.Width);
            return (length * width);
        }
        public decimal CalculatePerimeter(){
            decimal length = Convert.ToDecimal(this.Length);
            decimal width = Convert.ToDecimal(this.Width);
            return (2 * (length + width));
        }
    }
}