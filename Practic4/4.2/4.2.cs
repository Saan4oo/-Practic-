using System;

class Delivery
{
    private string _descriptionOrder;
    private int _weightOrder;

    public string DescriptionOrder
    {
        get { return _descriptionOrder; }
    }

    public int WeightOrder
    {
        get { return _weightOrder; }
    }

    public Delivery(string descriptionOrder, int weightOrder)
    {
        _descriptionOrder = descriptionOrder;
        _weightOrder = weightOrder;
    }

    public string Order()
    {
        return _descriptionOrder;
    }
}

class DeliveryService
{
    private int _limitWeight = 5;

    public void SendOrders(Delivery delivery)
    {
        if (_limitWeight >= delivery.WeightOrder)
        {
            _limitWeight -= delivery.WeightOrder;
            Console.WriteLine($"'{delivery.Order()}': отправка удалась");
        }
        else
        {
            Console.WriteLine($"'{delivery.Order()}': отправка не удалась, превышена норма веса на {delivery.WeightOrder - _limitWeight} кг.");
        }
    }
}

class PostOffice
{
    public static void StartLine()
    {
        Console.WriteLine("----------------------------------------------------");
    }

    public static void HelloString()
    {
        Console.WriteLine("Приветствуем вас на нашей почте");
    }
}

class Program
{
    static void Main()
    {
        PostOffice.StartLine();
        PostOffice.HelloString();
        PostOffice.StartLine();

        Delivery lamp = new Delivery("Лампа", 1);
        Delivery table = new Delivery("Стол", 10);

        DeliveryService deliveryService = new DeliveryService();
        deliveryService.SendOrders(lamp);
        deliveryService.SendOrders(table);
    }
}
