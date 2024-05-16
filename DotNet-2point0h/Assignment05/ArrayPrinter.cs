using System.Collections;
class ArrayPrinter{
    public T[] PrintArray<T>(T[] array) {
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine(array[i]);
        }
        return array;
    }
}