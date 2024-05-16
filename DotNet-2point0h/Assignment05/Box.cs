class Box<T> {
    private T item;

    // Constructor
    public Box() {
        
    }

    // Generic method to return the item
    public T GetValue() {
        return item;
    }

    public T SetValue(T item) {
        return this.item = item;
    }

    public void Swap(Box<T> anotherBox){
        T box1 = this.item;
        T box2 = anotherBox.item;

        anotherBox.item = box1;
        this.item = box2;
    }

    // Generic property
    public T Item { get; set; }
}