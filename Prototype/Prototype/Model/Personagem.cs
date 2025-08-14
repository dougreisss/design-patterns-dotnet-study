using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Model
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; }
        public int PontosVida { get; set; }
        public int PontosMana { get; set; }
        public Arma Arma { get; set; }
    }
}
