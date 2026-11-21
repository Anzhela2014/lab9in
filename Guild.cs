public class Guild {
    private List<Hero> _heroes = new List<Hero>();

    public string Name { get; private set; }
    public int HeroesCount => _heroes.Count;

    public Guild(string name) {
        Name = name;
    }

    public bool AddHero(Hero hero) {
        if (hero == null) {
            return false;
        }

        foreach (Hero item in _heroes) {
            if (item.Name == hero.Name) {
                return false;
            }
        }

        _heroes.Add(hero);
        return true;
    }
}
