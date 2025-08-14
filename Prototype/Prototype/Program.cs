using Prototype.Model;

PersonagemA personagem1 = new PersonagemA();
personagem1.Nome = "Merlin";
personagem1.Classe = "Mago";
personagem1.Nivel = 10;
personagem1.PontosVida = 100;
personagem1.PontosMana = 200;
personagem1.Arma = new Arma("Cajado");

Personagem personagem2 = new PersonagemA();

//Não irá impactar o objeto inimigo2
personagem2 = personagem1.DeepCopy(); //Cópia profuda
personagem1.Arma.Nome = "Espada";

//irá impactar o objeto inimigo2
personagem2 = personagem1.ShallowCopy(); //Cópia superficial
personagem1.Arma.Nome = "Espada";
