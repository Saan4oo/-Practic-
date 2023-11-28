using System;

class SmsMessage
{
    private double _price;
    private string _messageText;

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public string MessageText
    {
        get { return _messageText; }
        set { _messageText = value; }
    }

    public void PriceCount()
    {
        if (_messageText.Length <= 65)
        {
            _price = 1.5;
        }
        else
        {
            if (_messageText.Length > 250)
            {
                _messageText = _messageText.Substring(0, 250);
                _price = (_messageText.Length - 65) * 0.5 + 1.5;
                Console.WriteLine(_messageText);
                return;
            }
            _price = (_messageText.Length - 65) * 0.5 + 1.5;
        }

        Console.WriteLine(_messageText);
    }

    static void Main()
    {
        SmsMessage smsMessage = new SmsMessage();
        smsMessage.MessageText = "БИБАБОБА";
        smsMessage.PriceCount();
    }
}
