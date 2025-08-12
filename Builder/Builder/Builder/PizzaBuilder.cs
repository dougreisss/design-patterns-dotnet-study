using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Model;

namespace Builder.Builder
{
    public class PizzaBuilder
    {
        private readonly Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public PizzaBuilder SetSabor(string sabor)
        {
            _pizza.Sabor = sabor;
            return this;
        }

        public PizzaBuilder SetTamanho(string tamanho)
        {
            _pizza.Tamanho = tamanho;
            return this;
        }

        public PizzaBuilder TemBordaRecheada()
        {
            _pizza.BordaRecheada = true;
            return this;
        }

        public PizzaBuilder TipoMassa(string tipoMassa)
        {
            _pizza.TipoMassa = tipoMassa;   
            return this;
        }

        public PizzaBuilder TipoMolho(string tipoMolho) 
        {
            _pizza.TipoMolho = tipoMolho;
            return this;
        }

        public Pizza Build() => _pizza;
    }
}
