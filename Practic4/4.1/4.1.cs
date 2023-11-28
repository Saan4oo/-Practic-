using System;

class Spell
{
    private int _mana;
    private string _effect;

    public int Mana
    {
        get { return _mana; }
        private set { _mana = value; }
    }

    public string Effect
    {
        get { return _effect; }
        private set { _effect = value; }
    }

    public Spell(int mana, string effect)
    {
        Mana = mana;
        Effect = effect;
    }

    public string Use()
    {
        return _effect;
    }
}

class Magician
{
    private int _mana;
    private string _name;

    public int Mana
    {
        get { return _mana; }
        private set { _mana = value; }
    }

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public Magician(int mana, string name)
    {
        Mana = mana;
        Name = name;
    }

    public void CastSpell(Spell spell)
    {
        if (_mana >= spell.Mana)
        {
            Console.WriteLine($"{_name} использует способность: '{spell.Use()}'");
            _mana -= spell.Mana;
            Console.WriteLine($"У {_name} осталось {_mana} маны\n");
        }
        else
        {
            Console.WriteLine($"Не хватает {spell.Mana - _mana} для использования заклинания: '{spell.Use()}'");
            Console.WriteLine($"{_name} советую выпить зелье восстановления маны!");
        }
    }
}

class Program
{
    static void Main()
    {
        Spell tornado = new Spell(100, "Tornado");
        Spell blast = new Spell(50, "Blast");

        Magician harryPotter = new Magician(150, "Invoker");

        harryPotter.CastSpell(tornado);
        harryPotter.CastSpell(blast);
    }
}
