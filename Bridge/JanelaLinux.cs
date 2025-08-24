namespace Bridge;

public class JanelaLinux : IJanelaBridge
{
    public void desenharBotao(string titulo)
    {
        Console.WriteLine($"{titulo} - Botão Linux");
    }

    public void desenharJanela(string titulo)
    {
        Console.WriteLine($"{titulo} - Janela Linux");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("teste");
        }
    }
}
