public class Store {
    public string Name { get; private set; }
    public List<Product> Products { get; private set; } = new List<Product>();

    public Store(string name) {
        Name = name;
    }
}
