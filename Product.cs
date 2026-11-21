public class Product {
    public string Name;
    public double Price;
    public string Category;
    public int Stock { get; private set; }
    public bool IsAvailable;

    public Product(string name, double price, string category, int stock) {
        Name = name;
        Price = price;
        Category = category;

        if (stock < 0) {
            Stock = 0;
        } else {
            Stock = stock;
        }

        IsAvailable = true;
    }

    public void AddStock(int amount) {
        if (amount <= 0) {
            return;
        }

        Stock += amount;
    }
}
