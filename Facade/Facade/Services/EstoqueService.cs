using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Model;

namespace Facade.Services
{
    public class EstoqueService
    {
        public bool VerificarEstoque(Pedido pedido)
        {
            return pedido.Produto == "Teclado"; 
        }
    }
}
