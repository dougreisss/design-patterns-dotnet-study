using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? Produto { get; set; }
        public string? NomeSolicitante { get; set; }
        public string? EmailSolicitante { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
