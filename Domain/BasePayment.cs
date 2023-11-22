namespace Domain;

using System;

public class BasePayment
{
    public int Id { get; set; }
    public string Description { get; set; }

    public virtual void Pay()
    {
        //Implementation
        Console.WriteLine("payment implementation");
    }
}