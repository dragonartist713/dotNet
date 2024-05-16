public class Container<T>{
    
    public List<T> Value;
    public void AddItem(T item){
        this.Value.Add(item);
    }
    public void RemoveItem(T item){
        this.Value.Remove(item);
    }
}