using Builder.Builder;

PizzaBuilder pizzaBuilder = new();

var pizzaMussarela = pizzaBuilder
        .SetSabor("Mussarela")
        .SetTamanho("Grande")
        .TipoMolho("Tomate")
        .TipoMassa("Fina")
        .TemBordaRecheada()
        .Build();

pizzaBuilder = new();

var pizzaFrangoRequeijao = pizzaBuilder
        .SetSabor("Frango com Requeijão")
        .SetTamanho("Grande")
        .TipoMolho("Tomate")
        .TipoMassa("Fina")
        .Build();

Console.WriteLine(pizzaMussarela.ToString());
Console.WriteLine("-------------------------");
Console.WriteLine(pizzaFrangoRequeijao.ToString());