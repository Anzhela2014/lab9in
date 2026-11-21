Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

Console.WriteLine("\nЗадание: Магазин");

Product product1 = new Product("Ноутбук", 55000, "Электроника", 5);
Product product2 = new Product("Наушники", 3500, "Аксессуары", 12);
Product product3 = new Product("Клавиатура", 4200, "Периферия", 0);

product3.IsAvailable = false;

Console.WriteLine($"Товар 1: {product1.Name}, категория: {product1.Category}, цена: {product1.Price} руб., на складе: {product1.Stock}, в наличии: {product1.IsAvailable}");
Console.WriteLine($"Товар 2: {product2.Name}, категория: {product2.Category}, цена: {product2.Price} руб., на складе: {product2.Stock}, в наличии: {product2.IsAvailable}");
Console.WriteLine($"Товар 3: {product3.Name}, категория: {product3.Category}, цена: {product3.Price} руб., на складе: {product3.Stock}, в наличии: {product3.IsAvailable}");
