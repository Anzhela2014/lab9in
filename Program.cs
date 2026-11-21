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
