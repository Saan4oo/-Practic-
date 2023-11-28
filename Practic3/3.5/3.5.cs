using System;

namespace CSharpExample
{
    class SmsMessage
    {
        private double _limitPrice;
        private int _maxLength;
        private double _price;
        private string _messageText;

        public double LimitPrice
        {
            get { return _limitPrice; }
            set { _limitPrice = value; }
        }

        public int MaxLength
        {
            get { return _maxLength; }
            set { _maxLength = value; }
        }

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

        public double PriceCount()
        {
            if (_messageText.Length <= 65)
            {
                _price = 1.5;
            }
            else
            {
                if (_messageText.Length > _maxLength)
                {
                    _messageText = _messageText.Substring(0, _maxLength);
                    _price = (_messageText.Length - 65) * 0.5 + _price;
                    Console.WriteLine(_messageText);
                    return _price;
                }
                _price = (_messageText.Length - 65) * 0.5 + _price;
            }
            Console.WriteLine(_messageText);
            return _price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmsMessage smsMessage = new SmsMessage();
            smsMessage.MessageText = "pisya";

            smsMessage.LimitPrice = 0.9;
            smsMessage.MaxLength = 200;
            smsMessage.Price = 5.9;

            Console.WriteLine($"{smsMessage.PriceCount()}");
        }
    }
}
