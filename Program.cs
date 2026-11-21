// Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

int firstIndex = 0;

if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[firstIndex].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;
foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[firstIndex];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

Console.WriteLine("\n>>> Задание: Магазин <<<");

Product product1 = new Product("Ноутбук", 55000, "Электроника", 5);
Product product2 = new Product("Наушники", 3500, "Аксессуары", 12);
Product product3 = new Product("Клавиатура", 4200, "Периферия", 0);
product3.IsAvailable = false;

Store store = new Store("Мой магазин");
store.Products.Add(product1);
store.Products.Add(product2);
store.Products.Add(product3);

Product product4 = new Product("Монитор", 24000, "Электроника", 4);
store.Products.Add(product4);

Console.WriteLine($"Товаров в магазине: {store.Products.Count}");

if (store.Products.Count > 0) {
    Console.WriteLine($"Первый товар: {store.Products[firstIndex].Name}");
    Console.WriteLine($"Последний товар: {store.Products[store.Products.Count - 1].Name}");
}

Console.WriteLine();
foreach (Product item in store.Products) {
    Console.WriteLine(item.GetInfo());
}

int expensiveCount = 0;
foreach (Product item in store.Products) {
    if (item.Price > 5000) {
        expensiveCount += 1;
    }
}
Console.WriteLine($"Товаров дороже 5000 руб.: {expensiveCount}");

product1.AddStock(5);
Console.WriteLine($"Остаток ноутбуков через переменную: {product1.Stock}");
Console.WriteLine($"Остаток ноутбуков через список: {store.Products[firstIndex].Stock}");
