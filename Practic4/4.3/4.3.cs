using System;
using System.Threading;

class Ork
{
    private int _count = 1;
    private int gold;
    private int farming = 2;

    public int Count { get { return _count; } }
    public int Gold { get { return gold; } }

    public int BuyOrk()
    {
        Console.WriteLine("Добро пожаловать в лавку.");
        Console.WriteLine("Купить орка - 5 монет");
        string a = Console.ReadLine();
        if (a == "Купить")
        {
            if (gold - 5 < 0)
            {
                Console.WriteLine("Золота недостаточно, приходите позже");
            }
            else
            {
                gold -= 5;
                _count++;
                return gold;
            }
        }

        if (_count >= 5)
        {
            farming -= 2;
        }

        return gold;
    }

    public int Mining()
    {
        while (true)
        {
            string key = Console.ReadLine();
            if (key == "Магазин")
            {
                BuyOrk();
            }
            else if (key == "Баланс")
            {
                Console.WriteLine($"Ваш баланс == {gold}");
                Console.WriteLine("Напишите exit, чтобы выйти");
            }
            else if (key == "Заработать")
            {
                Thread.Sleep(4000);
                Console.WriteLine($"Ваш орк успешно добыл {farming} монет(ы)");
                gold += farming * _count;
            }
            else if (key == "Выйти")
            {
                break;
            }
            else
            {
                continue;
            }
        }

        return gold;
    }
}

class Program
{
    static void Main()
    {
        Ork ork = new Ork();

        Console.WriteLine("Выберите, что вы хотите:");
        Console.WriteLine("* Заработать");
        Console.WriteLine("* Баланс");
        Console.WriteLine("* Магазин");

        ork.Mining();
        Console.WriteLine($"Вы заработали == {ork.Gold} монет и наняли {ork.Count} орка");
    }
}
