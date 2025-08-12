using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
    public class Pizza
    {
        public string? Sabor { get; set; }
        public string? Tamanho { get; set; }
        public bool BordaRecheada { get; set; }
        public string? TipoMassa { get; set; }
        public string? TipoMolho { get; set; }

        public override string ToString()
        {
            return $"Pizza: {Tamanho} de Sabor {Sabor}, Massa {TipoMassa}, Molho {TipoMolho} " +
                   $"\nBorda Recheada: {(BordaRecheada ? "Sim" : "Não")}";
        }
    }
}
