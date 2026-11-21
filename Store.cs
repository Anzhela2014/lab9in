public class Store {
    private List<Product> _products = new List<Product>();

    public string Name { get; private set; }
    public int ProductsCount => _products.Count;

    public Store(string name) {
        Name = name;
    }

    public bool AddProduct(Product product) {
        if (product == null) {
            return false;
        }

        if (FindProductByName(product.Name) != null) {
            return false;
        }

        _products.Add(product);
        return true;
    }

    public Product? FindProductByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string cleanName = name.Trim();

        foreach (Product item in _products) {
            if (item.Name == cleanName) {
                return item;
            }
        }

        return null;
    }
}
