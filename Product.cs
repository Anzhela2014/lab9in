public class Product {
    public string Name;
    public double Price;
    public string Category;
    public int Stock;
    public bool IsAvailable;

    public Product(string name, double price, string category, int stock) {
        Name = name;
        Price = price;
        Category = category;
        Stock = stock;
        IsAvailable = true;
    }

    public void AddStock(int amount) {
        if (amount <= 0) {
            return;
        }

        Stock += amount;
    }
}
