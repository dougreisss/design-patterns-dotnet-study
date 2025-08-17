using Adapter.Interfaces;

namespace Adapter.Adapters
{
    public class PaypalAdapter : IPagamento
    {
        public void Pagar(decimal valor)
        {
            PaypalServices paypalServices = new PaypalServices();
            paypalServices.EfetuarPagamento(10);
        }
    }
}

