using System;

public class OrderProcessor
{
    // Delegate
    public delegate void OrderPlacedHandler(Order order);

    // Event
    public event OrderPlacedHandler OnOrderPlaced;

    public void ProcessOrder(Order order)
    {
        Console.WriteLine("\nProcessing Order...");

        // Trigger event
        OnOrderPlaced?.Invoke(order);
    }
}