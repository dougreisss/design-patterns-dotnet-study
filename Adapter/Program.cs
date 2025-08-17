using Adapter.Adapters;

PaypalAdapter paypalAdapter = new PaypalAdapter();

paypalAdapter.Pagar(10);

StripeAdapter stripeAdapter = new StripeAdapter();

stripeAdapter.Pagar(25);