public class Utilities {

    public T Max<T>(T value1, T value2) where T : IComparable<T> {
		int result = value1.CompareTo(value2);
        if(result > 0){
            return value2;
        }
        return value1;
    }
    
}