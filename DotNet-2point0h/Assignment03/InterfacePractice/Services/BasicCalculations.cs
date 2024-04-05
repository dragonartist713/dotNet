using Interfaces;

namespace Services{
    class BasicCalculations: ICalculations {
        public int Add(int one, int two){
            int sum = one + two;
            return sum;
        }
        public int Subtract(int one, int two){
            int diff = one - two;
            return diff;
        }
    }
}