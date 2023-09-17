public class PaymentService
{
    private readonly int cost = 0;
    private readonly bool includeDelivery = false;

    private PaymentStrategy strategy = new PaymentByCreditCard();

    public void SetStrategy(PaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ProcessOrder()
    {
        strategy.CollectPaymentDetails();
        if (strategy.ValidatePaymentDetails())
        {
            strategy.Pay(GetTotal());
        }
    }

    private int GetTotal()
    {
        return includeDelivery ? cost + 10 : cost;
    }
}