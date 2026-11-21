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

        if (FindHeroByName(hero.Name) != null) {
            return false;
        }

        _heroes.Add(hero);
        return true;
    }

    public Hero? FindHeroByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string cleanName = name.Trim();

        foreach (Hero hero in _heroes) {
            if (hero.Name == cleanName) {
                return hero;
            }
        }

        return null;
    }
}
