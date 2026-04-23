using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Order ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

     
        Order order = new Order
        {
            OrderId = id,
            CustomerName = name,
            Amount = amount
        };

        OrderProcessor processor = new OrderProcessor();

      
        EmailService email = new EmailService();
        SMSService sms = new SMSService();
        LoggerService logger = new LoggerService();

     
        processor.OnOrderPlaced += email.SendEmail;
        processor.OnOrderPlaced += sms.SendSMS;
        processor.OnOrderPlaced += logger.LogOrder;

  
        processor.ProcessOrder(order);

        Console.ReadLine();
    }
}
