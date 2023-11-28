using System;
using System.Runtime.CompilerServices;

class Car
{
    public double maxSpeed;

    public Car() 
    {
        this.maxSpeed = 185;
    }
    public Car(double speed) 
    {
        this.maxSpeed = speed;
    }
    public double CalculateTime(double distance)
    {
        return distance / maxSpeed;
    }
}
class Program
{
    static void Main()
    {
        Car Comaro = new Car();
        Console.WriteLine($"{Comaro.CalculateTime(185)}");

        Car BMW = new Car(345);
        Console.WriteLine($"{BMW.CalculateTime(185)}");

        Car Lada2114 = new Car(169);
        Console.WriteLine($"{Lada2114.CalculateTime(185)}");
    }
}