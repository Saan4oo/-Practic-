using System;

class Color
{
    private int _red;
    private int _green;
    private int _blue;

    public int Red
    {
        get { return _red; }
        set { _red = NormalizeColorValue(value); }
    }

    public int Green
    {
        get { return _green; }
        set { _green = NormalizeColorValue(value); }
    }

    public int Blue
    {
        get { return _blue; }
        set { _blue = NormalizeColorValue(value); }
    }

    public Color(int red = 0, int green = 0, int blue = 0)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    private int NormalizeColorValue(int colorValue)
    {
        if (colorValue > 255)
        {
            return 255;
        }
        if (colorValue < 0)
        {
            return 0;
        }
        return colorValue;
    }

    public void DisplayColor()
    {
        Console.WriteLine($"{_red}, {_green}, {_blue}");
    }
}

class Program
{
    static void Main()
    {
        Color yellow = new Color(300, 300, 0);
        yellow.DisplayColor();

        Color pink = new Color();
        pink.Red = 255;
        pink.Green = -20;
        pink.Blue = 147;

        pink.DisplayColor();
    }
}
