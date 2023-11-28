using System;
using System.Collections.Generic;

class MyIntList
{
    private List<int> _numbersList = new List<int>();

    public List<int> NumbersList
    {
        get { return _numbersList; }
    }

    public double Average
    {
        get { return CalculateAverage(); }
    }

    public void AddNumber(int number)
    {
        _numbersList.Add(number);
    }

    public void RemoveNumber(int number)
    {
        _numbersList.Remove(number);
    }

    private double CalculateAverage()
    {
        if (_numbersList.Count == 0)
        {
            return 0.0;
        }

        int totalSum = _numbersList.Sum();
        return (double)totalSum / _numbersList.Count;
    }
}

class Program
{
    static void Main()
    {
        MyIntList numbers = new MyIntList();
        numbers.AddNumber(1);
        numbers.AddNumber(2);
        numbers.AddNumber(2);

        Console.WriteLine(numbers.Average);
    }
}
