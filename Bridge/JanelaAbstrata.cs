namespace Bridge;

public abstract class JanelaAbstrata
{
    protected IJanelaBridge _janelaBridge;
    public JanelaAbstrata(IJanelaBridge janelaBridge)
    {
        _janelaBridge = janelaBridge;
    }

    public void desenharJanela(string titulo)
    {
        _janelaBridge.desenharJanela(titulo);
    }

    public void desenharBotao(string titulo)
    {
        _janelaBridge.desenharBotao(titulo);
    }

    public abstract void desenhar();
}
