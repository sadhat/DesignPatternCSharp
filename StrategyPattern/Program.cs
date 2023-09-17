internal class Program
{
    private static void Main(string[] args)
    {
        new PaymentService().SetStrategy(new PaymentByPayPal());
        new PaymentService().ProcessOrder();
    }
}