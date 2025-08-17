namespace Adapter;

public class PaypalServices
{
    public void EfetuarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de {valor} processado via Paypal");
    }
}
