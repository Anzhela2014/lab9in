Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);

bool duplicateHero = guild.AddHero(new Hero("Ярослав", 80));
Console.WriteLine($"Добавили дубликат Ярослава: {duplicateHero}");
Console.WriteLine($"Всего героев: {guild.HeroesCount}");

Hero? foundHero = guild.FindHeroByName("Александр");
if (foundHero != null) {
    Console.WriteLine($"Найден: {foundHero.Name}, здоровье {foundHero.Health}");
} else {
    Console.WriteLine("Герой не найден");
}

Hero? missingHero = guild.FindHeroByName("Дмитрий");
if (missingHero == null) {
    Console.WriteLine("Герой Дмитрий не найден");
}

Console.WriteLine("\n>>> Задание: Магазин <<<");

Product product1 = new Product("Ноутбук", 55000, "Электроника", 5);
Product product2 = new Product("Наушники", 3500, "Аксессуары", 12);
Product product3 = new Product("Клавиатура", 4200, "Периферия", 0);
product3.IsAvailable = false;

Store store = new Store("Мой магазин");
store.AddProduct(product1);
store.AddProduct(product2);
store.AddProduct(product3);

bool duplicateProduct = store.AddProduct(new Product("Ноутбук", 60000, "Электроника", 2));
Console.WriteLine($"Добавили дубликат ноутбука: {duplicateProduct}");
Console.WriteLine($"Всего товаров: {store.ProductsCount}");

Product? foundProduct = store.FindProductByName("Наушники");
if (foundProduct != null) {
    Console.WriteLine($"Найден товар: {foundProduct.Name}, цена {foundProduct.Price} руб., остаток {foundProduct.Stock}");
} else {
    Console.WriteLine("Товар не найден");
}

Product? missingProduct = store.FindProductByName("Планшет");
if (missingProduct == null) {
    Console.WriteLine("Товар Планшет не найден");
}
