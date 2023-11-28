using System;
using System.Runtime.CompilerServices;

class Car
{
    public double maxSpeed;
    public string CarModal;

    public Car()
    {
        this.maxSpeed = 185;
    }
    public Car(double speed)
    {
        this.maxSpeed = speed;
    }
    public Car(double speed, string CarName)
    {
        maxSpeed = speed;
        CarModal = CarName;
    }
    public double CalculateTime(double distance)
    {
        Console.WriteLine(CarModal);
        return distance / maxSpeed;
    }
    public double CalculateTime()
    {
        double distance = 185;
        Console.WriteLine(CarModal);
        return distance / maxSpeed;
    }
}
class Program
{
    static void Main()
    {
        Car Comaro = new Car();
        Console.WriteLine($"{Comaro.CalculateTime()}");

        Car BMW = new Car(345);
        Console.WriteLine($"{BMW.CalculateTime()}");

        Car Lada2114 = new Car(169, "4etiro4ka");
        Console.WriteLine($"{Lada2114.CalculateTime()}");

    }
}