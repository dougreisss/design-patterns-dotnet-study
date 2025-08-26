using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Model;
using Facade.Services;

namespace Facade
{
    public class PedidoFacade
    {
        EstoqueService estoqueService = new EstoqueService();
        PagamentoService pagamentoService = new PagamentoService();
        EntregaService entregaService = new EntregaService();    
        NotificacaoService notificacaoService = new NotificacaoService();
        public void FinalizarPedido(Pedido pedido)
        {
            Console.WriteLine($"Verificando estoque para {pedido.Produto}");

            if (estoqueService.VerificarEstoque(pedido))
            {
                Console.WriteLine("Produto disponível");
                Console.WriteLine($"Processando pagamento de {pedido.ValorTotal.ToString("C")}");

                if(pagamentoService.ProcessarPagamento())
                {
                    Console.WriteLine("Pagamento aprovado");

                    if (entregaService.AgendarEntrega(pedido))
                    {
                        Console.WriteLine("Entrega Agendada");
                        notificacaoService.EnviarNotificacao(pedido.NomeSolicitante, pedido.EmailSolicitante);
                        Console.WriteLine("Pedido finalizado");
                    }
                }
            }
        }
    }
}
