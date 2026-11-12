Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");

Console.WriteLine("\nЗадание: Магазин");

Product product1 = new Product("Ноутбук", 55000, "Электроника", 5);
Product product2 = new Product("Наушники", 3500, "Аксессуары", 12);
Product product3 = new Product("Клавиатура", 4200, "Периферия", 0);

product3.IsAvailable = false;

Console.WriteLine($"Товар 1: {product1.Name}, категория: {product1.Category}, цена: {product1.Price} руб., на складе: {product1.Stock}, в наличии: {product1.IsAvailable}");
Console.WriteLine($"Товар 2: {product2.Name}, категория: {product2.Category}, цена: {product2.Price} руб., на складе: {product2.Stock}, в наличии: {product2.IsAvailable}");
Console.WriteLine($"Товар 3: {product3.Name}, категория: {product3.Category}, цена: {product3.Price} руб., на складе: {product3.Stock}, в наличии: {product3.IsAvailable}");
