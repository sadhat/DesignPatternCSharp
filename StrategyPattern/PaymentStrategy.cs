using System;

public abstract class PaymentStrategy
{
    public abstract void CollectPaymentDetails();

    public abstract bool ValidatePaymentDetails();

    public abstract void Pay(int amount);
}

public class CreditCard
{
    public CreditCard(string cardNumber, DateOnly expiryDate, string cvv)
    {
        CardNumber = cardNumber;
        ExpiryDate = expiryDate;
        Cvv = cvv;
    }

    public string CardNumber { get; }

    public DateOnly ExpiryDate { get; }

    public string Cvv { get; }
}

public class PaymentByCreditCard : PaymentStrategy
{
    private CreditCard? card;

    public override void CollectPaymentDetails()
    {
        card = new CreditCard("1234-333-1234", DateOnly.Parse("01/01/1900"), "200");
    }

    public override bool ValidatePaymentDetails()
    {
        // Validate Credit Card
        return false;
    }

    public override void Pay(int amount)
    {
        Console.WriteLine($"Paying {amount} using Credit Card");
    }
}

public class PaymentByPayPal : PaymentStrategy
{
    private string email = string.Empty;
    private string password = string.Empty;

    public override void CollectPaymentDetails()
    {
        email = "...";
        password = "...";
    }

    public override bool ValidatePaymentDetails()
    {
        // Validate account...
        return false;
    }

    public override void Pay(int amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal");
    }
}