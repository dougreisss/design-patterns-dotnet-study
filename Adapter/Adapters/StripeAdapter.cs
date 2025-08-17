using Adapter.Interfaces;

namespace Adapter.Adapters
{
    public class StripeAdapter : IPagamento
    {
        public void Pagar(decimal valor)
        {
            StripeServices stripeServices = new StripeServices();
            stripeServices.MakePayment(valor);
        }
    }
}

