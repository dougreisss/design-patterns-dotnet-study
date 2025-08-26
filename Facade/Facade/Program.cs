using Facade;
using Facade.Model;

Pedido pedido = new Pedido
{
    Id = 1,
    Produto = "Teclado",
    NomeSolicitante = "Douglas",
    EmailSolicitante = "Douglas@email.com",
    ValorTotal = 100
};

PedidoFacade pedidoFacade = new PedidoFacade();

pedidoFacade.FinalizarPedido(pedido);