using Decorator;
using Decorator.Decorator.Concrete;

ICarro carro = new Carro();         
ICarro rodaDecorator = new RodaLigaLeveDecorator(carro);
ICarro arDecorator = new ArCondicionadoDecorator(rodaDecorator);
ICarro bancoDecorator = new ArCondicionadoDecorator(arDecorator);
ICarro multiMidiaDecorator = new KitMultimidiaDecorator(bancoDecorator);

var result = multiMidiaDecorator.RetornarCarro();

Console.WriteLine(result);  
