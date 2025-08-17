namespace Adapter;

public class StripeServices
{
    public void MakePayment(decimal value)
    {
        Console.WriteLine($"Pagamento de {value} processado via Stripe");
    }
}
