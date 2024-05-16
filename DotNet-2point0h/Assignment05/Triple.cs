public class Triple<T,U,V> {
    public T First;
    public U Second;
    public V Third;

    // Constructor
    public Triple(T item, U thing, V trinket) {
        this.First = item;
        this.Second = thing;
        this.Third = trinket;
    }


    // Generic property
    public T Item { get; set; }
}