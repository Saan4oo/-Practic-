using System;
    class EquationSolution
    {
        private double a, b, c;
        private double resultX1, resultX2;

        public EquationSolution(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private double CalculateDiscriminant()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        private void CalculateRoots()
        {
            double discriminant = CalculateDiscriminant();
            double sqrtDiscriminant = Math.Sqrt(discriminant);

            double divisor = 2 * a;

            double x1 = Math.Round((-b + sqrtDiscriminant) / divisor, 2);
            double x2 = Math.Round((-b - sqrtDiscriminant) / divisor, 2);

            resultX1 = discriminant < 0 ? 0.000001 : x1;
            resultX2 = discriminant != 0 ? x2 : resultX1;
        }

        public double GetX1()
        {
            CalculateRoots();
            return resultX1;
        }

        public double GetX2()
        {
            CalculateRoots();
            return resultX2;
        }
    }

    class Num2
    {
        private int n;

        public Num2(int initialNumber)
        {
            n = initialNumber;
        }

        public int GetNum()
        {
            return n;
        }

        public bool SetNumber(int number)
        {
            bool isNumberValid = number == n + 1;

            if (isNumberValid)
            {
                n = number;
            }
            else
            {
                n = 0;
            }

            return isNumberValid;
        }
    }

class MainClasses
{
    static void Main()
    {
        double a, b, c;
        Console.Write("Введите а: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        c = Convert.ToDouble(Console.ReadLine());
        EquationSolution ES = new EquationSolution(a, b, c);
        double resultx1 = ES.GetX1();
        double resultx2 = ES.GetX2();
        if (resultx1 == 0.000001 && resultx2 == 0.000001)
        {
            Console.WriteLine("Корней нет!");
        }
        else
        {
            Console.WriteLine($" Х1 = {resultx1}, Х2 = {resultx2}");
        }
        int userInput = 0;
        Num2 num2 = new Num2(userInput);
        while (true)
        {
            // Вызов значения из функции(UserNumber = n)
            int UserNumber = num2.GetNum();

            userInput = Convert.ToInt32(Console.ReadLine());
            if (num2.SetNumber(userInput))
            {
                Console.WriteLine("\nВерное значение, можете продолжать.");
            }
            else
            {
                Console.WriteLine("Неверное значение. Начните заново.");
            }
        }
    }
}

