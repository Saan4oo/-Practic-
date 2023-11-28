using System;
class Car
{
    public double maxSpeed;
    public string CarModal;
    public double distance = 500;

    public Car(double speed, string CarName)
    {
        maxSpeed = speed;
        CarModal = CarName;
    }
    public double RideTime()
    {
        return Math.Round((distance / maxSpeed) * 3600);
    }
    public void Score()
    {
        int hour = Convert.ToInt32(RideTime() / 3600);
        int minute = Convert.ToInt32((RideTime() % 3600) / 60);
        int seconds = Convert.ToInt32(RideTime() % 60);
        Console.WriteLine("Время автомобиля " + CarModal + " : " + hour + " ч. " + minute + " мин. " + seconds + " сек.");
    }
}
class Program
{
    static void Main()
    {
        string Car11 = "Comaro";
        string Car22 = "BMW M5 Competition";
        string Car33 = "Nissan GT-R";
        string Car44 = "Porshe 911 GT3 RS";
        Console.WriteLine("==============================================================================================================");
        Console.WriteLine($"Гонка началась! В заезде учавствуют 4 водителя: {Car11}, {Car22}, {Car33}, {Car44}.");
        Console.WriteLine("==============================================================================================================");

        Car Car1 = new Car(300, Car11);
        Car1.Score();

        Car Car2 = new Car(305, Car22);
        Car2.Score();

        Car Car3 = new Car(315, Car33);
        Car3.Score();

        Car Car4 = new Car(326, Car44);
        Car4.Score();

        Console.WriteLine("===========================================================");
        Console.WriteLine("Заезд завершен! Вот результаты: ");

        double WinNumb = Math.Max(Math.Max(Car1.maxSpeed, Car2.maxSpeed), Math.Max(Car3.maxSpeed, Car4.maxSpeed));

        if (WinNumb == Car1.maxSpeed)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Победитель Гонки: " + Car1.CarModal);
            Console.WriteLine("==============================================");
        }
        else if (WinNumb == Car2.maxSpeed)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Победитель Гонки: " + Car2.CarModal);
            Console.WriteLine("==============================================");
        }
        else if (WinNumb == Car3.maxSpeed)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Победитель Гонки: " + Car3.CarModal);
            Console.WriteLine("==============================================");
        }
        else if (WinNumb == Car4.maxSpeed)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Победитель Гонки: " + Car4.CarModal);
            Console.WriteLine("==============================================");
        }
        else
        {
            Console.WriteLine("Победитель не определен!");
        }

    }
}