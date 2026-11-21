Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

Console.WriteLine("\nЗадание: Магазин");

Product product1 = new Product("Ноутбук", 55000, "Электроника", 5);
Product product2 = new Product("Наушники", 3500, "Аксессуары", 12);
Product product3 = new Product("Клавиатура", 4200, "Периферия", 0);
Product badProduct = new Product("Мышь", 1500, "Периферия", -5);

product3.IsAvailable = false;

Console.WriteLine($"Товар 1: {product1.Name}, категория: {product1.Category}, цена: {product1.Price} руб., на складе: {product1.Stock}, в наличии: {product1.IsAvailable}");
Console.WriteLine($"Товар 2: {product2.Name}, категория: {product2.Category}, цена: {product2.Price} руб., на складе: {product2.Stock}, в наличии: {product2.IsAvailable}");
Console.WriteLine($"Товар 3: {product3.Name}, категория: {product3.Category}, цена: {product3.Price} руб., на складе: {product3.Stock}, в наличии: {product3.IsAvailable}");
Console.WriteLine($"Проверка отрицательного остатка при создании ({badProduct.Name}): на складе {badProduct.Stock}");

Console.WriteLine();
Console.WriteLine($"Остаток товара 1 до пополнения: {product1.Stock}");
product1.AddStock(3);
Console.WriteLine($"После пополнения на 3: {product1.Stock}");
product1.AddStock(-2);
Console.WriteLine($"После попытки пополнить на -2: {product1.Stock}");
